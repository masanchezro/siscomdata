using Microsoft.AspNetCore.Http;
using OfficeOpenXml;
using System.IO;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;

[ApiController]
[Route("api/[controller]")]
public class LecturaExcelController : ControllerBase
{
    [HttpPost("ReadExcelPacientesToSQLFile")]
    public IActionResult ReadExcelPacientesToSQLFile(IFormFile file)
    {
        if (file == null || file.Length == 0)
        {
            return BadRequest("No file uploaded.");
        }

        // Set the license context to avoid the exception
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

        using (var stream = new MemoryStream())
        {
            file.CopyTo(stream);
            using (var package = new ExcelPackage(stream))
            {
                var sheet = package.Workbook.Worksheets[0];
                var rowCount = sheet.Dimension.Rows;

                var sqlStatements = new List<string>();

                for (int row = 2; row <= rowCount; row++)
                {
                    string transaccion = sheet.Cells[row, 1]?.Text?.Trim() ?? "NULL";
                    if (transaccion == string.Empty) { break; };

                    string estado = sheet.Cells[row, 23]?.Text?.Trim() ?? "NULL";

                    string sql = $@"
INSERT INTO [dbo].[TMCOTRPACIENTES] 
([IDWS], [IdTransaccion], [Delegacion], [NSS], [NoAfiliacion], [AgrMedico], [Unidad], [Consultorio], [Turno], [Apellidos], [Nombre], [FechaNacimiento], [EstadoCivil], [Ocupacion], [Estatura], [Peso], [Calle], [Numero], [NumeroInt], [Cruce1], [Cruce2], [Colonia], [Ciudad], [Estado], [CodPostal], [RefDomicilio], [Celular], [EMail], [Equipo], [Observaciones],[ClienteFactura]) 
VALUES 
(
(SELECT MAX(IDWS) + 1 FROM [dbo].[TMCOTRPACIENTES]), 
{FormatValue(sheet.Cells[row, 1]?.Text)}, 
{FormatValue(sheet.Cells[row, 2]?.Text)}, 
{FormatValue(sheet.Cells[row, 3]?.Text)}, 
{FormatValue(sheet.Cells[row, 4]?.Text)}, 
{FormatValue(sheet.Cells[row, 5]?.Text)}, 
{FormatValue(sheet.Cells[row, 6]?.Text, isNumeric: true)}, 
{FormatValue(sheet.Cells[row, 7]?.Text)}, 
{FormatValue(sheet.Cells[row, 8]?.Text)}, 
{FormatValue(sheet.Cells[row, 9]?.Text)}, 
{FormatValue(sheet.Cells[row, 10]?.Text)}, 
{FormatValue(sheet.Cells[row, 11]?.Text)}, 
{FormatValue(sheet.Cells[row, 12]?.Text)}, 
{FormatValue(sheet.Cells[row, 13]?.Text)}, 
{FormatValue(sheet.Cells[row, 14]?.Text)}, 
{FormatValue(sheet.Cells[row, 15]?.Text)}, 
{FormatValue(sheet.Cells[row, 16]?.Text)}, 
{FormatValue(sheet.Cells[row, 17]?.Text)}, 
{FormatValue(sheet.Cells[row, 18]?.Text)}, 
{FormatValue(sheet.Cells[row, 19]?.Text)}, 
{FormatValue(sheet.Cells[row, 20]?.Text)}, 
{FormatValue(sheet.Cells[row, 21]?.Text)}, 
{FormatValue(sheet.Cells[row, 22]?.Text)}, 
(SELECT Id_Estado FROM [dbo].[TCCOGREDO] WHERE NombreEstado = {FormatValue(estado)}), 
{FormatValue(sheet.Cells[row, 24]?.Text)}, 
{FormatValue(sheet.Cells[row, 25]?.Text, isNumeric: true)}, 
{FormatValue(sheet.Cells[row, 26]?.Text)}, 
{FormatValue(sheet.Cells[row, 27]?.Text, isNumeric: true)}, 
{FormatValue(sheet.Cells[row, 28]?.Text)}, 
{FormatValue(sheet.Cells[row, 29]?.Text)}, 
{0}
);";
                    sqlStatements.Add(sql.Replace("\n", "").Replace("\r", "").Trim());
                }

                var sqlScript = string.Join("\n", sqlStatements);

                var filePath = @"C:\archivos\InsercionPacientes.sql";

                if (System.IO.File.Exists(filePath))
                {
                    System.IO.File.Delete(filePath);
                }

                System.IO.File.WriteAllText(filePath, sqlScript);

                return Ok(new { Message = "SQL file created successfully.", FilePath = filePath });
            }
        }
    }

    [HttpPost("ReadRecetasExcelToSqlFile")]
    public IActionResult ReadRecetasExcelToSqlFile(IFormFile file)
    {
        if (file == null || file.Length == 0)
        {
            return BadRequest("No file uploaded.");
        }

        // Set the license context for EPPlus
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

        using (var stream = new MemoryStream())
        {
            file.CopyTo(stream);
            using (var package = new ExcelPackage(stream))
            {
                var sheet = package.Workbook.Worksheets[0];
                var rowCount = sheet.Dimension.Rows;

                var sqlStatements = new List<string>();

                for (int row = 2; row <= rowCount; row++)
                {

                    string idTransaccion = sheet.Cells[row, 1]?.Text?.Trim() ?? "NULL";

                    if (idTransaccion    == string.Empty) { break; };

                    string delegacion = sheet.Cells[row, 2]?.Text?.Trim() ?? "NULL";
                    string folio = sheet.Cells[row, 3]?.Text?.Trim() ?? "NULL";
                    string nss = sheet.Cells[row, 4]?.Text?.Trim() ?? "NULL";
                    string noAfiliacion = sheet.Cells[row, 5]?.Text?.Trim() ?? "NULL";
                    string agrMedico = sheet.Cells[row, 6]?.Text?.Trim() ?? "NULL";
                    string unidad = sheet.Cells[row, 7]?.Text?.Trim() ?? "NULL";
                    string matriculaMed = sheet.Cells[row, 8]?.Text?.Trim() ?? "NULL";
                    string diagnostico = sheet.Cells[row, 9]?.Text?.Trim() ?? "NULL";
                    string diagnosticoDetalle = sheet.Cells[row, 10]?.Text?.Trim() ?? "NULL";
                    string fechaExpedicion = FormatDateValue(sheet.Cells[row, 11]?.Text);
                    string fechaInicio = FormatDateValue(sheet.Cells[row, 12]?.Text);
                    string fechaFinal = FormatDateValue(sheet.Cells[row, 13]?.Text);
                    string flujo = sheet.Cells[row, 14]?.Text?.Trim() ?? "NULL";
                    string periodo = sheet.Cells[row, 15]?.Text?.Trim() ?? "NULL";
                    string fechaModificacion = FormatDateValue(sheet.Cells[row, 16]?.Text);
                    string nvaFechaFin = FormatDateValue(sheet.Cells[row, 17]?.Text);
                    string motivo = sheet.Cells[row, 18]?.Text?.Trim() ?? "NULL";
                    string quitaUltDia = sheet.Cells[row, 19]?.Text?.Trim() ?? "NULL";
                    string noPaciente = sheet.Cells[row, 20]?.Text?.Trim() ?? "NULL";
                    string tipoMovimiento = sheet.Cells[row, 21]?.Text?.Trim() ?? "NULL";
                    string fechaAudit = FormatDateValue(sheet.Cells[row, 22]?.Text);

                    string sql = $@"
INSERT INTO [dbo].[TMCOTRRECETAS]
([IDWS], [IdTransaccion], [Delegacion], [Folio], [NSS], [NoAfiliacion], [AgrMedico], [Unidad], [MatriculaMed], 
[Diagnostico], [DiagnosticoDetalle], [FechaExpedicion], [FechaInicio], [FechaFinal], [Flujo], [Periodo], 
[FechaModificacion], [NvaFechaFin], [Motivo], [QuitaUltDia], [NoPaciente], [TipoMovimiento], [FechaAudit])
VALUES
(
(SELECT ISNULL(MAX(IDWS), 0) + 1 FROM [dbo].[TMCOTRRECETAS]),
{FormatValue(idTransaccion)}, {FormatValue(delegacion, isNumeric: true)}, {FormatValue(folio)}, {FormatValue(nss)},
{FormatValue(noAfiliacion)}, {FormatValue(agrMedico)}, {FormatValue(unidad, isNumeric: true)},
{FormatValue(matriculaMed)}, {FormatValue(diagnostico)}, {FormatValue(diagnosticoDetalle)}, 
{fechaExpedicion}, {fechaInicio}, {fechaFinal}, {FormatValue(flujo, isNumeric: true)},
{FormatValue(periodo, isNumeric: true)}, {fechaModificacion}, {nvaFechaFin}, {FormatValue(motivo)}, 
{FormatValue(quitaUltDia, isNumeric: true)}, {FormatValue(noPaciente)}, {FormatValue(tipoMovimiento, isNumeric: true)},
{fechaAudit}
);";
                    sqlStatements.Add(sql.Replace("\n", "").Replace("\r", "").Trim());
                }

                var sqlScript = string.Join("\n", sqlStatements);

                var filePath = @"C:\archivos\InsercionRecetas.sql";

                if (System.IO.File.Exists(filePath))
                {
                    System.IO.File.Delete(filePath);
                }

                System.IO.File.WriteAllText(filePath, sqlScript);

                return Ok(new { Message = "SQL file created successfully.", FilePath = filePath });
            }
        }
    }

    private string FormatValue(string value, bool isNumeric = false)
    {
        if (string.IsNullOrEmpty(value))
        {
            return "NULL"; // Return NULL for empty or null values
        }

        if (isNumeric)
        {
            return value.Trim(); // Return as is for numeric values
        }

        // Escape single quotes for string values
        return $"'{value.Trim().Replace("'", "''")}'";
    }

    private string FormatDateValue(string value)
    {
        if (DateTime.TryParse(value, out var date))
        {
            return $"'{date:yyyy-MM-dd HH:mm:ss}'";
        }
        return "NULL";
    }

}
