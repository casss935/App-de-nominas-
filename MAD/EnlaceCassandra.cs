using System;
using System.Collections.Generic;
using System.Linq;
using Cassandra;
using Cassandra.Mapping;
using System.Configuration;
using System.Windows.Forms;
using System.IO;
using MAD.Clases;
using MAD;

namespace WindowsFormsApplication2
{
    public class EnlaceCassandra
    {
        static private string _dbServer { set; get; }
        static private string _dbKeySpace { set; get; }
        static private Cluster _cluster;
        static private ISession _session;

        public static void conectar()
        {
            _dbServer = ConfigurationManager.AppSettings["Cluster"].ToString();
            _dbKeySpace = ConfigurationManager.AppSettings["KeySpace"].ToString();

            _cluster = Cluster.Builder()
                .AddContactPoint(_dbServer)
                .Build();

            _session = _cluster.Connect(_dbKeySpace);
        }


        public static void conectar2()
        {
            try
            {
                _cluster = Cluster.Builder()
                    .AddContactPoint("127.0.0.1")
                    .Build();

                _session = _cluster.Connect("keyspace1");
            }
            catch(Exception e)
            {
                MessageBox.Show("Ha ocurrido un error al intentar conectarse a la base de datos", "Base de datos", MessageBoxButtons.OK);
                Application.Exit();
            }

        }

        private static void desconectar()
        {
            _cluster.Dispose();
        }

        public RowSet GetAllUserAdmins()
        {
            conectar2();
            string query = "SELECT ID_empresa, ID_useradmin, name, password, user FROM useradmin WHERE ID_empresa =" + statics.ID_empresa + ";";
            RowSet lista = _session.Execute(query);
            desconectar();
            return lista;
        }
        public RowSet GetAllEmpresas()
        {
            conectar2();
            string query = "SELECT ID_empresa, razon_social, rfc, regis_patronal, fechainicio, address, estado, municipio, codigopostal FROM empresa";
            RowSet lista = _session.Execute(query);
            desconectar();
            return lista;
        }
        public List<datos_colaborador2> GetAllColaboradores()
        {
            conectar2();
            string query = "SELECT rfc, name, departamento,puesto,bday,curp,rfc,nss, id_numero FROM empleados WHERE ID_empresa ="+statics.ID_empresa+";";
            IMapper mapper = new Mapper(_session);
            IEnumerable<datos_colaborador2> datos = mapper.Fetch<datos_colaborador2>(query);
            desconectar();
            return datos.ToList();
        }

        public List<Datos_empresa2> Get_empresa()
        {
            conectar2();
            string query = "SELECT ID_empresa, razon_social, rfc, regis_patronal, fechainicio, address, estado, municipio, codigopostal FROM empresa";
            IMapper mapper = new Mapper(_session);
            IEnumerable<Datos_empresa2> datos_Empresas = mapper.Fetch<Datos_empresa2>(query);
            desconectar();
            return datos_Empresas.ToList();
        }

        public RowSet GetOneempresa(string rfc)
        {
            conectar2();
            string query = "SELECT razon_social, rfc, regis_patronal, fechainicio, address, estado, municipio, codigopostal FROM Empresas WHERE rfc =" + rfc + ";";
            RowSet lista = _session.Execute(query);
            desconectar();
            return lista;
        }

        public bool Agregar_empresa(Datos_empresa de, useradmin useradmin)
        {
            try
            {
                conectar2();
                string query = "INSERT INTO empresa (ID_empresa, razon_social, rfc, regis_patronal, FechaInicio, address, estado, municipio, codigopostal) values("+ de.ID_empresa+ ", '" + de.razon_social + "', '" + de.rfc + "', '" + de.regis_patronal + "', '" + de.fechainicio.ToString("yyyy-MM-dd") + "', '" + de.address + "','" + de.estado + "','" + de.municipio + "','" + de.codigopostal + "');";
                string query2 = "INSERT INTO useradmin (name, user, password, ID_empresa, ID_useradmin ) values('" + useradmin.name + "', '" + useradmin.user + "', '" + useradmin.password + "', " + useradmin.ID_empresa + " , "+ useradmin.ID_useradmin +");";
                _session.Execute(query);
                _session.Execute(query2);
                return true;

            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error al intentar agregar la empresa", "Empresa", MessageBoxButtons.OK);
                return false;
            }
            finally
            {
                MessageBox.Show("Se agrego correctamente la empresa", "Empresa", MessageBoxButtons.OK);
                desconectar();
            }
        }

        public bool Agregar_useradmin(useradmin useradmin)
        {
            try
            {
                conectar2();
                string query = "INSERT INTO useradmin (name, user, password, ID_useradmin, ID_empresa) values('" + useradmin.name + "', '" + useradmin.user + "', '" + useradmin.password + "', " + useradmin.ID_useradmin + " , "+ useradmin.ID_empresa +");";
                _session.Execute(query);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error al agregar el usuario administrador", "Administradores", MessageBoxButtons.OK);
                return false;
            }
            finally
            {                           
                desconectar();
            }
        }

        public bool Agregar_departamento(Datos_departamento departamento)
        {
            try
            {
                conectar2();
                
                string qry = "";
                string query = "INSERT INTO departamentos(ID_dep, ID_empresa, name, sueldobase) values({0}, {1}, '{2}', {3});";
                qry = string.Format(query, departamento.ID_dep, departamento.ID_empresa, departamento.name, departamento.sueldobase);
                _session.Execute(qry);
                return true;

            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un problema", "ERROR", MessageBoxButtons.OK);
                return false;
            }
            finally
            {
                desconectar();
                
            }
        }

        public bool Agregar_puesto(Datos_puesto puesto)
        {
            try
            {
                conectar2();
                Guid ID_puesto = Guid.NewGuid();
                string qry = "INSERT INTO puesto(ID_puesto, ID_empresa, name, nivel_salarial) values(" + puesto.ID_puesto +"," + puesto.ID_empresa + ", '" + puesto.name +"'," + puesto.nivel_salarial+");";             
                _session.Execute(qry);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un problema al intentar agregar el puesto", "Empresa", MessageBoxButtons.OK);
                return false;
            }
            finally
            {
                MessageBox.Show("Se agrego correctamente", "Puestos", MessageBoxButtons.OK);
                desconectar();
            }
        }

        public bool update_empleado(datos_colaborador datos)
        {
            try
            {
                conectar2();
                string query = "UPDATE Empresas SET name = '{0}', password = '{1}', departamento = '{2}', puesto = '{3}', bday = '{4}', curp = '{5}', nss = '{6}', rfc = '{7}', banco = '{8}', no_cuenta = '{9}', email = '{10}', telefono = '{11}', address = '{12}', estado = '{13}', municipio = '{14}', codigopostal = '{15}'";
                string qry = string.Format(query, datos.name, datos.password, datos.departamento, datos.puesto, datos.bday.ToString("yyyy-MM-dd"), datos.curp, datos.nss, datos.rfc, datos.banco, datos.no_cuenta, datos.email, datos.telefono, datos.address, datos.estado, datos.municipio, datos.codigopostal);
                _session.Execute(qry);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Hubo un problema al querer actualizar los datos", "Colaborador", MessageBoxButtons.OK);
                return false;

            }
            finally
            {
                MessageBox.Show("Datos del colaborador actualizados correctamente", "Colaborador", MessageBoxButtons.OK);
                desconectar();
            }
        }

        public bool Agregar_colaborador(datos_colaborador datos)
        {
            try
            {
                conectar2();
                Guid ID_numero = Guid.NewGuid();              
                string query = "INSERT INTO empleados(id_numero, id_empresa, name, password, departamento, id_dep, puesto, id_puesto, registro, bday, curp, nss, rfc, banco, no_cuenta, email, telefono, address, estado, municipio, codigopostal) values(" + ID_numero + "," +datos.ID_empresa+",'"+datos.name+"','"+datos.password+"','"+datos.departamento+"',"+datos.id_dep+",'"+datos.puesto+"',"+datos.id_puesto+",'"+datos.registro.ToString("yyyy-MM-dd") + "','"+datos.bday.ToString("yyyy-MM-dd") + "','"+datos.curp+"','"+datos.nss+"','"+ datos.rfc+"','"+datos.banco+"','"+datos.no_cuenta+"','"+datos.email+"','"+datos.telefono+"','"+datos.address+"','"+datos.estado+"','"+datos.municipio+"','"+datos.codigopostal+"');";
             
                _session.Execute(query);
                return true;
            }
            catch (Exception e)
            {
                
                MessageBox.Show("Hubo un problema al intentar agregar el colaborador", "Colaborador", MessageBoxButtons.OK);
                return false;
            }
            finally
            {
                
                desconectar();
            }

        }

        public RowSet GetOneColaborador(string rfc)
        {
            try
            {
                conectar2();
                string query = "SELECT id_numero, id_empresa, name, password, departamento, puesto, registro, bday, curp, nss, rfc, banco, no_cuenta, email, telefono, address, estado, municipio, codigopostal FROM empleados WHERE ID_empresa ="+statics.ID_empresa+"AND ID_numero = " + rfc + ";";
                RowSet lista = _session.Execute(query);
                return lista;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                desconectar();
            }
        }
        public List<datos_colaborador> GetOneColaboradorByEmpresa()
        {
            try
            {
                conectar2();
                string query = "SELECT  password , rfc, ID_numero name, FROM empleados WHERE ID_empresa =" + statics.ID_empresa + ";";
                IMapper mapper = new Mapper(_session);
                IEnumerable<datos_colaborador> datos_Empresas = mapper.Fetch<datos_colaborador>(query);
                desconectar();
                return datos_Empresas.ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                desconectar();
            }
        }
        public RowSet GetOneDepartamento(Guid ID_dep)
        {
            try
            {
                conectar2();
                string query = "SELECT ID_empresa, ID_dep, name, sueldobase FROM Departamentos WHERE ID_empresa = " + statics.ID_empresa + " AND ID_dep =" + ID_dep + ";";
                RowSet lista = _session.Execute(query);
                return lista;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                desconectar();
            }
        }

        public void Delete_departamento(Guid ID_dep)
        {
            try
            {
                conectar2();
                string query = "DELETE FROM departamentos WHERE ID_empresa = " + statics.ID_empresa+ "AND ID_dep = "+ID_dep+";";
                _session.Execute(query);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hubo un problema al intentar eliminar el elemento", "Eliminar departamentos", MessageBoxButtons.OK);
            }
            finally
            {
                MessageBox.Show("Se elimino correctamente", "Eliminar departamentos", MessageBoxButtons.OK);
                desconectar();
            }
        }

        public bool Delete_puesto(Datos_puesto puesto)
        {
            try
            {
                conectar2();
                string query = "DELETE FROM puesto WHERE ID_empresa = " + puesto.ID_empresa + " AND ID_puesto = " + puesto.ID_puesto + ";";
                _session.Execute(query);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Hubo un problema al intentar eliminar el elemento", "Eliminar puesto", MessageBoxButtons.OK);
                return false;
            }
            finally
            {                
                desconectar();
            }
        }

        public bool Delete_empleado(Guid id_numero)
        {
            try
            {
                conectar2();
                string query = "DELETE FROM empleados WHERE id_empresa = " + statics.ID_empresa + " AND id_numero =" + id_numero + ";";
                _session.Execute(query);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Hubo un problema al querer eliminar el colaborador", "Colaborador", MessageBoxButtons.OK);
                return false;
            }
            finally
            {
                
                desconectar();
            }

        }
        public List<Datos_departamento> Get_departamento()
        {
            try {
                conectar2();
                string query = "SELECT ID_empresa, ID_dep, name, sueldobase FROM Departamentos WHERE ID_empresa = " + statics.ID_empresa + ";";

                IMapper mapper = new Mapper(_session);
                IEnumerable<Datos_departamento> depto = mapper.Fetch<Datos_departamento>(query);

                return depto.ToList();
            }
            catch ( Exception e)
            {
                return null;
                MessageBox.Show("Ha ocurrido un problema al intentar obtener la informacion", "Departamento", MessageBoxButtons.OK);
            }
            finally
            {
                desconectar();
            }

        }


        public List<Datos_departamento> Get_departamentoOneByIds(Guid ID_dep)
        {
            try
            {
                conectar2();
                string query = "SELECT ID_empresa, ID_dep, name, sueldobase FROM Departamentos WHERE ID_empresa = " + statics.ID_empresa + " AND ID_dep =" + ID_dep + ";";

                IMapper mapper = new Mapper(_session);
                IEnumerable<Datos_departamento> depto = mapper.Fetch<Datos_departamento>(query);

                return depto.ToList();
            }
            catch (Exception e)
            {
                return null;
                MessageBox.Show("Ha ocurrido un problema al intentar obtener la informacion", "Departamento", MessageBoxButtons.OK);
            }
            finally
            {
                desconectar();
            }

        }

        public List<Datos_puesto> Get_puesto()
        {
            try
            {
                conectar2();
                string query = "SELECT ID_empresa, ID_puesto, name, nivel_salarial FROM puesto WHERE ID_empresa = " + statics.ID_empresa + ";";
                IMapper mapper = new Mapper(_session);
                IEnumerable<Datos_puesto> puesto = mapper.Fetch<Datos_puesto>(query);
                return puesto.ToList();
            }
            catch(Exception e)
            {
                return null;
                MessageBox.Show("Ha ocurrido un problema al intentar obtener la informacion", "puesto", MessageBoxButtons.OK);
            }
            finally
            {
                desconectar();
            }


        }

        public List<Datos_puesto> Get_OnePuesto(Datos_puesto datos)
        {
            try
            {
                conectar2();
                string query = "SELECT ID_empresa, ID_puesto, name, nivel_salarial FROM puesto WHERE ID_empresa = " + datos.ID_empresa + "AND ID_puesto = " +datos.ID_puesto+";" ;
                IMapper mapper = new Mapper(_session);
                IEnumerable<Datos_puesto> puesto = mapper.Fetch<Datos_puesto>(query);
                return puesto.ToList();
            }
            catch (Exception e)
            {
                return null;
                MessageBox.Show("Ha ocurrido un problema al intentar obtener la informacion", "puesto", MessageBoxButtons.OK);
            }
            finally
            {
                desconectar();
            }


        }

        public bool update_departamento(Datos_departamento datos) 
        {
            try
            {                
                conectar2();
                string query = "UPDATE departamentos SET name = '"+datos.name+"', sueldobase = "+datos.sueldobase+" WHERE  ID_empresa = "+datos.ID_empresa+" AND ID_dep = "+datos.ID_dep+";";                                              
                _session.Execute(query);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Hubo un problema al intentar actualizar la informacion", "Departamento", MessageBoxButtons.OK);
                return false;
            }
            finally
            {
                MessageBox.Show("La informacion se actualizo correctamente", "Departamento", MessageBoxButtons.OK);
                desconectar();
            }

        }

        public bool update_puesto(Datos_puesto datos_)
        {
            try
            {
                conectar2();
                string query = "UPDATE puesto SET name ='" + datos_.name + "', nivel_salarial = " + datos_.nivel_salarial + " WHERE ID_empresa =" + datos_.ID_empresa + "AND ID_puesto = " + datos_.ID_puesto + ";";
                _session.Execute(query);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Hubo un problema al intentar actualizar la informacion", "Departamento", MessageBoxButtons.OK);
                return false;
            }
            finally
            {

                desconectar();
            }

        }

       public bool agregar_deduccion(Datos_deduccion deduccion)
        {
            try
            {
                conectar2();
                Guid ID_puesto = Guid.NewGuid();
                string qry = "INSERT INTO deduc(ID_deduc, ID_empresa, name, monto, tipo, fija) values(" + deduccion.ID_deduc + "," + deduccion.ID_empresa+ ", '" + deduccion.name+ "'," + deduccion.monto +",'"+ deduccion.tipo +"','"+deduccion.fija+"');";
                _session.Execute(qry);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un problema al intentar agregar la deduccion", "Empresa", MessageBoxButtons.OK);
                return false;
            }
            finally
            {                
                desconectar();
            }

        }

        public List<Datos_deduccion> Get_deduccion()
        {
            try
            {
                conectar2();
                string query = "SELECT ID_deduc, ID_empresa, name, monto, tipo FROM deduc WHERE ID_empresa = " + statics.ID_empresa + ";";
                IMapper mapper = new Mapper(_session);
                IEnumerable<Datos_deduccion> deduccions= mapper.Fetch<Datos_deduccion>(query);
                return deduccions.ToList();
            }
            catch (Exception e)
            {
                return null;
                MessageBox.Show("Hubo un problema al intentar obtener las deducciones", "Deducciones", MessageBoxButtons.OK);
            }
            finally
            {
                desconectar();
            }


        }

        public List<Datos_deduccion> Get_deduccionByID(Guid guid)
        {
            try
            {
                conectar2();
                string query = "SELECT ID_deduc, ID_empresa, name, monto, tipo FROM deduc WHERE ID_empresa = " + statics.ID_empresa + " AND ID_deduc = "+ guid +";";
                IMapper mapper = new Mapper(_session);
                IEnumerable<Datos_deduccion> deduccions = mapper.Fetch<Datos_deduccion>(query);
                return deduccions.ToList();
            }
            catch (Exception e)
            {
                return null;
                MessageBox.Show("Hubo un problema al intentar obtener las deducciones", "Deducciones", MessageBoxButtons.OK);
            }
            finally
            {
                desconectar();
            }


        }


        public bool agregar_pers(Datos_pers pers)
        {
            try
            {
                conectar2();
                Guid ID_puesto = Guid.NewGuid();
                string qry = "INSERT INTO percep(ID_percep, ID_empresa, name, monto, tipo, fija) values(" + pers.ID_percep+ "," + pers.ID_empresa + ", '" + pers.name + "'," + pers.monto + ",'" + pers.tipo + "','"+ pers.fija +"');";
                _session.Execute(qry);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un problema al intentar agregar la percepcion", "Percepcion", MessageBoxButtons.OK);
                return false;
            }
            finally
            {
                desconectar();
            }

        }



        public List<Datos_pers> Get_percepcion()
        {
            try
            {
                conectar2();
                string query = "SELECT ID_percep, ID_empresa, name, monto, tipo FROM percep WHERE ID_empresa = " + statics.ID_empresa + ";";
                IMapper mapper = new Mapper(_session);
                IEnumerable<Datos_pers> percepcion = mapper.Fetch<Datos_pers>(query);
                return percepcion.ToList();
            }
            catch (Exception e)
            {
                return null;
                MessageBox.Show("Hubo un problema al intentar obtener las percepciones", "Percepciones", MessageBoxButtons.OK);
            }
            finally
            {
                desconectar();
            }


        }



        public List<Datos_pers> Get_percepcionByID(Guid guid)
        {
            try
            {
                conectar2();
                string query = "SELECT ID_percep, ID_empresa, name, monto, tipo FROM percep WHERE ID_empresa = " + statics.ID_empresa + "AND ID_percep = "+ guid +";";
                IMapper mapper = new Mapper(_session);
                IEnumerable<Datos_pers> percepcion = mapper.Fetch<Datos_pers>(query);
                return percepcion.ToList();
            }
            catch (Exception e)
            {
                return null;
                MessageBox.Show("Hubo un problema al intentar obtener las percepciones", "Percepciones", MessageBoxButtons.OK);
            }
            finally
            {
                desconectar();
            }


        }

    }
}
