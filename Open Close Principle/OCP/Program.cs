// See https://aka.ms/new-console-template for more information

using SOLID_Principle.OCP;

var reportService = new ReportService();

reportService.ReportType(new Excel(),"Hello this is Excel");
reportService.ReportType(new Pdf(),"Hello this is PDF");
reportService.ReportType(new Xml(),"Hello this is XML");
