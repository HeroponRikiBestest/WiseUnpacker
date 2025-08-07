namespace SabreTools.Models.WiseInstaller
{
    /// <summary>
    /// Wise installer overlay data header
    /// </summary>
    /// <see href="https://codeberg.org/CYBERDEV/REWise/src/branch/master/src/wiseoverlay.h"/> 
    public class OverlayHeader
    {
        /// <summary>
        /// DLL name length, if it exists
        /// </summary>
        public byte DllNameLen { get; set; }

        /// <summary>
        /// DLL name, missing if <see cref="DllNameLen"/> is 0 
        /// </summary>
        public string? DllName { get; set; }

        /// <summary>
        /// DLL size, missing if <see cref="DllNameLen"/> is 0 
        /// </summary>
        public uint? DllSize { get; set; }

        /// <summary>
        /// Packing flags
        /// </summary>
        public OverlayHeaderFlags Flags { get; set; }

        /// <summary>
        /// Graphics data
        /// </summary>
        /// <remarks>
        /// 12 bytes
        /// 
        /// When the data is processed, it does the following:
        /// 
        /// ushort[] colors = new ushort[3];
        /// int colorsPtr = 0;
        /// 
        /// for (int i = 0; i < 3; i++)
        /// {
        ///     uint color = (GraphicsData[i + 3] * <mult>) / 0x5F + GraphicsData[i];
        ///     colors[colorsPtr] = color;
        ///     if (color < 0)
        ///         colors[colorsPtr] = 0;
        ///     if (colors[colorsPtr] > 0xFF)
        ///         colors[colorsPtr] = 0xFF
        /// 
        ///     colorsPtr++;
        /// }
        /// </remarks>
        public byte[]? GraphicsData { get; set; }

        /// <summary>
        /// Points to the Exit event in the script, if it exists
        /// </summary>
        public uint WiseScriptExitEventOffset { get; set; }

        /// <summary>
        /// Points to the Cancel event in the script, if it exists
        /// </summary>
        public uint WiseScriptCancelEventOffset { get; set; }

        /// <summary>
        /// Inflated size of the Wise installer script
        /// </summary>
        public uint WiseScriptInflatedSize { get; set; }

        /// <summary>
        /// Deflated size of the Wise installer script
        /// </summary>
        public uint WiseScriptDeflatedSize { get; set; }

        /// <summary>
        /// Deflated size of WISE0001.DLL
        /// </summary>
        public uint WiseDllDeflatedSize { get; set; }

        /// <summary>
        /// Deflated size of CTL3D32.DLL
        /// </summary>
        public uint Ctl3d32DeflatedSize { get; set; }

        /// <summary>
        /// Deflated size of unknown data
        /// </summary>
        public uint SomeData4DeflatedSize { get; set; }

        /// <summary>
        /// Deflated size of Ocxreg32.EXE,
        /// </summary>
        public uint RegToolDeflatedSize { get; set; }

        /// <summary>
        /// Deflated size of PROGRESS.DLL
        /// </summary>
        public uint ProgressDllDeflatedSize { get; set; }

        /// <summary>
        /// Deflated size of unknown data
        /// </summary>
        public uint SomeData7DeflatedSize { get; set; }

        /// <summary>
        /// Deflated size of unknown data
        /// </summary>
        public uint SomeData8DeflatedSize { get; set; }

        /// <summary>
        /// Deflated size of unknown data
        /// </summary>
        /// <remarks>Samples were MS-DOS executables</remarks>
        public uint SomeData9DeflatedSize { get; set; }

        /// <summary>
        /// Deflated size of unknown data
        /// </summary>
        public uint SomeData10DeflatedSize { get; set; }

        /// <summary>
        /// Deflated size of FILE000{n}.DAT
        /// </summary>
        public uint FinalFileDeflatedSize { get; set; }

        /// <summary>
        /// Inflated size of FILE000{n}.DAT
        /// </summary>
        public uint FinalFileInflatedSize { get; set; }

        /// <summary>
        /// On multi-disc installers this is set to 0x00000000, so it may
        /// represent EOF instead of filesize? At least for now. Only compared
        /// the two multi-disc installers listed in the README.md, need more
        /// multi-disc installers to properly compare. On single file
        /// installers this is this installer it's filesize.
        /// </summary>
        public uint EOF { get; set; }

        /// <summary>
        /// Deflated size of the DIB
        /// </summary>
        /// <remarks>First file</remarks>
        public uint DibDeflatedSize { get; set; }

        /// <summary>
        /// Inflated size of the DIB
        /// </summary>
        /// <remarks>First file</remarks>
        public uint DibInflatedSize { get; set; }

        /// <summary>
        /// Deflated size of the install script
        /// </summary>
        /// <remarks>Only present in later versions</remarks>
        public uint? InstallScriptDeflatedSize { get; set; }

        /// <summary>
        /// Unknown
        /// </summary>
        /// <remarks>Only present in later versions</remarks>
        public uint? UnknownU32_4 { get; set; }

        /// <summary>
        /// Endianness of the file(?)
        /// </summary>
        public Endianness Endianness { get; set; }

        /// <summary>
        /// Init text length
        /// </summary>
        public byte InitTextLen { get; set; }

        /// <summary>
        /// Init text whose length is given by <see cref="InitTextLen"/> 
        /// </summary>
        public string? InitText { get; set; }
    }
}
