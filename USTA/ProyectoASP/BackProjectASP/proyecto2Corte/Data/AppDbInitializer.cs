using proyecto2Corte.Models;  // Actualizar el namespace a FinalProject.Models si es diferente

namespace proyecto2Corte.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
                context.Database.EnsureCreated();

                // Seed Usuario
                if (!context.Usuario.Any())
                {
                    context.Usuario.AddRange(new List<Usuario>()
                    {
                        new Usuario { Nombre = "John Doe", CorreoElectronico = "john.doe@example.com", Contraseña = "12345", Rol = "Profesor" },
                        new Usuario { Nombre = "Jane Smith", CorreoElectronico = "jane.smith@example.com", Contraseña = "abcde", Rol = "Estudiante" },
                        new Usuario { Nombre = "Alice Johnson", CorreoElectronico = "alice.johnson@example.com", Contraseña = "password", Rol = "Egresado" },
                        new Usuario { Nombre = "Bob Brown", CorreoElectronico = "bob.brown@example.com", Contraseña = "123abc", Rol = "Administrativo" },
                        new Usuario { Nombre = "Charlie Davis", CorreoElectronico = "charlie.davis@example.com", Contraseña = "sales123", Rol = "Estudiante" }
                    });
                    context.SaveChanges();
                }

                // Seed Peticion
                if (!context.Peticion.Any())
                {
                    context.Peticion.AddRange(new List<Peticion>()
                    {
                        new Peticion { FechaPeticion = DateTime.Now, Nombre = "Complaint", Descripcion = "Issue with service", Correo = "correo1@example.com", Documento = "12345", Asunto = "Service Issue" },
                        new Peticion { FechaPeticion = DateTime.Now.AddDays(-2), Nombre = "Query", Descripcion = "Inquiry about product", Correo = "correo2@example.com", Documento = "23456", Asunto = "Product Inquiry" },
                        new Peticion { FechaPeticion = DateTime.Now.AddDays(-1), Nombre = "Request", Descripcion = "Request for information", Correo = "correo3@example.com", Documento = "34567", Asunto = "Information Request" },
                        new Peticion { FechaPeticion = DateTime.Now.AddDays(-3), Nombre = "Suggestion", Descripcion = "Suggestion for improvement", Correo = "correo4@example.com", Documento = "45678", Asunto = "Improvement Suggestion" },
                        new Peticion { FechaPeticion = DateTime.Now.AddDays(-4), Nombre = "Complaint", Descripcion = "Complaint about pricing", Correo = "correo5@example.com", Documento = "56789", Asunto = "Pricing Complaint" }
                    });
                    context.SaveChanges();
                }

                // Seed Respuesta
                if (!context.Respuesta.Any())
                {
                    context.Respuesta.AddRange(new List<Respuesta>()
                    {
                        new Respuesta { IdUsuario = 1, IdPeticion = 1, RespuestaTexto = "We are looking into your service issue.", FechaRespuesta = DateTime.Now },
                        new Respuesta { IdUsuario = 2, IdPeticion = 2, RespuestaTexto = "Thank you for your inquiry.", FechaRespuesta = DateTime.Now.AddDays(-2) },
                        new Respuesta { IdUsuario = 3, IdPeticion = 3, RespuestaTexto = "We will provide the information shortly.", FechaRespuesta = DateTime.Now.AddDays(-1) },
                        new Respuesta { IdUsuario = 4, IdPeticion = 4, RespuestaTexto = "Your suggestion has been noted.", FechaRespuesta = DateTime.Now.AddDays(-3) },
                        new Respuesta { IdUsuario = 5, IdPeticion = 5, RespuestaTexto = "The pricing issue has been resolved.", FechaRespuesta = DateTime.Now.AddDays(-4) }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
