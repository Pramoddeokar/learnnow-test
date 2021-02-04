// <copyright file="FileType.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace Microsoft.Teams.Apps.LearnNow.Models
{
    /// <summary>
    /// Supported file types for upload file to blob.
    /// </summary>
    public static class FileType
    {
        /// <summary>
        /// The default XML-based file format for Excel .
        /// </summary>
        public const string XLSX = ".xlsx";

        /// <summary>
        /// Microsoft Excel Binary file format.
        /// </summary>
        public const string XLS = ".xls";

        /// <summary>
        /// The default XML-based file format for Microsoft Word.
        /// </summary>
        public const string DOCX = ".docx";

        /// <summary>
        /// Microsoft Word Binary File Format.
        /// </summary>
        public const string DOC = ".doc";

        /// <summary>
        /// Microsoft Power Binary File Format.
        /// </summary>
        public const string PPT = ".ppt";

        /// <summary>
        /// The default XML-based file format for Microsoft PowerPoint.
        /// </summary>
        public const string PPTX = ".pptx";

        /// <summary>
        /// The default PDF.
        /// </summary>
        public const string PDF = ".pdf";
    }
}
