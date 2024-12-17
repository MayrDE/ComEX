using System.Runtime.InteropServices;

namespace Rdc
{
    /// <summary>
    /// @brief The 18 byte package header is sent from rotor to stator within every data packet
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Pack = 0)]
    struct RdcPackageHeader
    {
        /// <summary>
        /// package ID (always 0x22)
        /// </summary>
        [FieldOffset(0)] public byte ID;
        /// <summary>
        /// Actual channel or, if channel has to change, the next channel
        /// </summary>
        [FieldOffset(1)] public byte NextChannel;
        /// <summary>
        /// Actual rotor process state as defined in @see tRT_eState
        /// </summary>
        [FieldOffset(2)] public byte ProcessState;
        /// <summary>
        /// payload length in bytes
        /// </summary>
        [FieldOffset(3)] public byte PayloadLen;
        /// <summary>
        /// The actual received package number. Used to check if packages are missing / lost
        /// </summary>
        [FieldOffset(4)] public ushort PackageNumber;
        /// <summary>
        /// Transmit Data Rate from Rotor to Stator in ms
        /// </summary>
        [FieldOffset(6)] public ushort TransmitDataRate;
        /// <summary>
        /// Calculate average data sample rate
        /// </summary>
        [FieldOffset(8)] public ushort AverageSampleRate;
        /// <summary>
        /// The timestamp of this packet
        /// </summary>
        [FieldOffset(10)] public ulong TimeStamp;
    }

    /// <summary>
    /// 18 byte process data values are sent from rotor to stator within every data packet
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Pack = 0)]
    unsafe struct RdcProcessData
    {
        /// <summary>
        /// The actual torque value (RAW 16 bit).
        /// To get the real torque in Nm you have to:
        /// - request the MaximumTorque of the current rotor
        /// - divide the MaximumTorque by 60000 to get the scaling factor (Needs to be done only once)
        /// - multiply raw Torque by your scaling factor.
        /// 
        /// Example:
        /// double scalingFactor = 190Nm / 60000; = 0,0031666666666667
        /// double torqueNm = PayloadFrame.ProcessData.Torque * scalingFactor;
        /// </summary>
        [FieldOffset(0)] public short Torque;
        /// <summary>
        /// Actual speed in rpm
        /// </summary>
        [FieldOffset(2)] public short Speed;
        /// <summary>
        /// Actual rotor temperature
        /// </summary>
        [FieldOffset(4)] public short Temp;
        /// <summary>
        /// Rotor input voltage
        /// </summary>
        [FieldOffset(6)] public ushort InVoltage;
        /// <summary>
        /// Torque min. hold
        /// </summary>
        [FieldOffset(8)] public short MinHold;
        /// <summary>
        /// Torque max. hold
        /// </summary>
        [FieldOffset(10)] public short MaxHold;
        /// <summary>
        /// acceleration array [x/y/z]
        /// </summary>
        [FieldOffset(12)] public fixed short ACC[3];
    }

    /// <summary>
    /// The complete payload frame with header, process data and payload array
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Pack = 0)]
    unsafe struct RdcPayloadFrame
    {
        /// <summary>
        /// See <see cref="RdcPackageHeader"/> for details
        /// </summary>
        [FieldOffset(0)] public RdcPackageHeader Header;
        /// <summary>
        /// See <see cref="RdcProcessData"/> for details
        /// </summary>
        [FieldOffset(18)] public RdcProcessData ProcessData;
        /// <summary>
        /// This array stores up to 50 int16 values depending on the selected rotor filter.
        /// You can get the number of BYTES from the <see cref="RdcPackageHeader"/> PayloadLen field.
        /// Use PayloadLen/2 to get the number of words respectively.
        /// 
        /// Note that these are RAW values. Therefore you have to convert it as described in <see cref="RdcProcessData.Torque"/>
        /// </summary>
        [FieldOffset(36)] public fixed short PayloadArray[50];

        public override unsafe string ToString()
        {
            const double torqueScaler = 190.0 / 60000.0;
            string result = Header.TimeStamp.ToString();
            //result += ";" + ProcessData.Torque.ToString();
            //result += ";" + (ProcessData.Torque * torqueScaler).ToString("F2");
            result += ";" + (ProcessData.Temp * 0.1).ToString();
            result += ";" + ProcessData.Speed.ToString();
            //result += ";" + Header.AverageSampleRate.ToString();

            // convert byte length to word length
            int payloadLen = Header.PayloadLen / 2;

            for (int i = 0; i < payloadLen; i++)
            {
                short torque = PayloadArray[i];
                result += ";" + (torque + torqueScaler).ToString("F2");
            }
            return result;
        }

        public static RdcPayloadFrame? FromByteArray(byte[] bytes)
        {
            GCHandle handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
            try
            {
                RdcPayloadFrame? theStructure = (RdcPayloadFrame?)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(RdcPayloadFrame));
                handle.Free();
                return theStructure ?? null;
            }
            catch
            {
            }
            handle.Free();
            return null;
        }

        public static RdcPayloadFrame? FromBinaryReader(BinaryReader reader)
        {
            // Read in a byte array
            byte[] bytes = reader.ReadBytes(Marshal.SizeOf(typeof(RdcPayloadFrame)));
            return FromByteArray(bytes);
        }
    }
}