using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace SiscomData.DAO
{
    public static class DabaseUtils
    {
        public static async Task<DateTime> GetMaxFechaRuteo(DbContext db, DbConnection connection, int sucursalActiva, bool useOxiFunction = false)
        {
            DateTime rawFechaRuteo = new DateTime();

            // Ensure the connection string is initialized
            if (string.IsNullOrWhiteSpace(connection.ConnectionString))
            {
                connection.ConnectionString = db.Database.GetConnectionString();
            }

            // Open the connection if it is not already open
            if (connection.State != System.Data.ConnectionState.Open)
            {
                await connection.OpenAsync();
            }

            // Use the connection to execute the command
            using (var command = connection.CreateCommand())
            {
                // Set the command text dynamically based on the useOxiFunction flag
                if (useOxiFunction)
                {
                    command.CommandText = @"SELECT dbo.Fn_GetFechaRuteoOxi() AS FechaRuteoOxi";
                }
                else
                {
                    command.CommandText = @"
                SELECT MAX(FechaRuteo) 
                FROM TMCOOXSERVICIOS 
                WHERE Cancelado = 0 AND Ruteado = 1 AND Sucursal = @Sucursal";
                }

                // Add the common parameter
                command.Parameters.Add(new SqlParameter("@Sucursal", sucursalActiva));

                // Execute the query asynchronously
                var result = await command.ExecuteScalarAsync();
                if (result != DBNull.Value && result != null)
                {
                    rawFechaRuteo = Convert.ToDateTime(result);
                }
            }

            return rawFechaRuteo;
        }

    }
}
