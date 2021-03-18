using Business.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class UsuarioAdapter : Adapter
    {
        public List<Usuario> GetAll()
        {
            try
            {
                List<Usuario> usuarios = new List<Usuario>();

                this.OpenConnection();

                SqlCommand cmdUsuarios = new SqlCommand("select u.*, pe.legajo from usuarios u inner join personas pe on pe.id_persona = u.id_persona", SqlConn);

                SqlDataReader drUsuarios = cmdUsuarios.ExecuteReader();

                while (drUsuarios.Read())
                {
                    Usuario usr = new Usuario();

                    usr.ID = (int)drUsuarios["id_usuario"];
                    usr.NombreUsuario = (string)drUsuarios["nombre_usuario"];
                    usr.Clave = (string)drUsuarios["clave"];
                    usr.Habilitado = (bool)drUsuarios["habilitado"];
                    usr.Nombre = (string)drUsuarios["nombre"];
                    usr.Email = (string)drUsuarios["email"];
                    usr.Apellido = (string)drUsuarios["apellido"];
                    usr.Persona = new Persona()
                    {
                        ID = (int)drUsuarios["id_persona"],
                        Legajo = (int)drUsuarios["legajo"]
                    };

                    usuarios.Add(usr);
                }
                drUsuarios.Close();
                this.CloseConnection();

                return usuarios;
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la lista de usuarios", ex);
                throw ExcepcionManejada;
            }
            //finally
            //{
            //    this.CloseConnection();
            //}
        }

        public Business.Entities.Usuario GetOne(int ID)
        {
            Usuario usuario = new Usuario();
            try
            {
                this.OpenConnection();
                SqlCommand cmdUsuarios = new SqlCommand("select u.*, pe.legajo from usuarios u inner join personas pe on pe.id_persona = u.id_persona where id_usuario = @id", SqlConn);
                cmdUsuarios.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drUsuarios = cmdUsuarios.ExecuteReader();
                if (drUsuarios.Read())
                {
                    usuario.ID = (int)drUsuarios["id_usuario"];
                    usuario.NombreUsuario = (string)drUsuarios["nombre_usuario"];
                    usuario.Clave = (string)drUsuarios["clave"];
                    usuario.Habilitado = (bool)drUsuarios["habilitado"];
                    usuario.Nombre = (string)drUsuarios["nombre"];
                    usuario.Apellido = (string)drUsuarios["apellido"];
                    usuario.Email = (string)drUsuarios["email"];
                    usuario.Persona = new Persona()
                    {
                        ID = (int)drUsuarios["id_persona"],
                        Legajo = (int)drUsuarios["legajo"]
                    };
                }
                drUsuarios.Close();
                return usuario;
            }
            catch (Exception ex)
            {
                Exception ExcepcionManjeada = new Exception("Error al recuperar datos de usuario", ex);
                throw ExcepcionManjeada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdDelete = new SqlCommand("delete usuarios where id_usuario=@id", SqlConn);

                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;

                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al Eliminar Usuario", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Update(Usuario usuario)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand(
                    "UPDATE usuarios set nombre_usuario = @nombre_usuario,clave = @clave," +
                    "habilitado = @habilitado , nombre = @nombre , apellido = @apellido , email = @email , id_persona = @persona " +
                    "WHERE id_usuario=@id", SqlConn);

                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = usuario.ID;
                cmdSave.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = usuario.NombreUsuario;
                cmdSave.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = usuario.Clave;
                cmdSave.Parameters.Add("@habilitado", SqlDbType.Bit).Value = usuario.Habilitado;
                cmdSave.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = "";
                cmdSave.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = "";
                cmdSave.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = "";
                cmdSave.Parameters.Add("@persona", SqlDbType.Int, 50).Value = usuario.Persona.ID;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos del usuario", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Insert(Usuario usuario)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdInsert = new SqlCommand(
                    "insert into usuarios(nombre_usuario,clave,habilitado,nombre,apellido,email,id_persona)" +
                    "values(@nombre_usuario,@clave,@habilitado,@nombre,@apellido,@email,@persona)" +
                    "select @@identity",
                    SqlConn);

                cmdInsert.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = usuario.NombreUsuario;
                cmdInsert.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = usuario.Clave;
                cmdInsert.Parameters.Add("@habilitado", SqlDbType.Bit).Value = usuario.Habilitado;
                cmdInsert.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = "";
                cmdInsert.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = "";
                cmdInsert.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = "";
                cmdInsert.Parameters.Add("@persona", SqlDbType.Int, 50).Value = usuario.Persona.ID;
                usuario.ID = Decimal.ToInt32((decimal)cmdInsert.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al insertar datos del usuario", ex);
                throw ExcepcionManejada;
            }
        }

        public void Save(Usuario usuario)
        {
            if (usuario.State == BusinessEntity.States.New)
            {
                this.Insert(usuario);
            }
            else if (usuario.State == BusinessEntity.States.Deleted)
            {
                this.Delete(usuario.ID);
            }
            else if (usuario.State == BusinessEntity.States.Modified)
            {
                this.Update(usuario);
            }
            usuario.State = BusinessEntity.States.Unmodified;
        }

        public bool Authenticate(string usuario, string contraseña)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdAuthenticate = new SqlCommand("select * from usuarios where(nombre_usuario = @usuario and clave = @contraseña)", SqlConn);
                cmdAuthenticate.Parameters.Add("@usuario", SqlDbType.NVarChar).Value = usuario;
                cmdAuthenticate.Parameters.Add("@contraseña", SqlDbType.NVarChar).Value = contraseña;
                SqlDataReader drAuth = cmdAuthenticate.ExecuteReader();
                return drAuth.Read();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos para iniciar sesion", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
    }
}