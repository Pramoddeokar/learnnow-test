// <copyright file="file-types.ts" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

export interface IFileAttachmentInfo {
    ContentType: string,
    FileName: string,
    ContentLength: string,
    ShowAttachment: boolean,
    BlobUrl: string,
}

export class FileType {
    public static readonly XLSX: string = "xlsx";
    public static readonly XLS: string = "xls";
    public static readonly DOCX: string = "docx";
    public static readonly DOC: string = "doc";
    public static readonly PPT: string = "ppt";
    public static readonly PPTX: string = "pptx";
    public static readonly PDF: string = "pdf";
}