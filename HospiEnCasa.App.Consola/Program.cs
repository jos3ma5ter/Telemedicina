using System;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;
namespace HospiEnCasa.App.Consola
{
    class Program
    {
        private static IRepositorioMascota _repoMascota;
        private static IRepositorioVeterinario _repoVeterinario;
        private static IRepositorioFamiliarDesignado _repoFamiliar;
        private static IRepositorioSignoVital _repoSignoVital;
        private static IRepositorioHistoria _repoHistoria;
        public static IRepositorioSugerenciaCuidado _repoSugerenciaCuidado;
        static void Main(string[] args)
        {
            //Console.WriteLine("PRUEBA CRUD");

            //AddSignoVital();
            //BuscarSignoVital(4);
            //EliminarSignoVital(5);
            //ActualizarSignoVital(1);
            //listaSignoVital();

            //AddSugerenciaCuidado();
            //BuscarSugerenciaCuidado();
            //EliminarSugerenciaCuidado(9);
            //ActualizarSugerenciaCuidado(7);
            //listaSugerenciaCuidado();

            //ddHistoria();
            //BuscarHistoria(8); da exepcion
            //EliminarHistoria(1);
            //listaHistoria();

            //AddMascota();
            //BuscarMascota(1018);
            //EliminarMascota(3);
            //AddVeterinario();
            //BuscarVeterinario(1);
            //AddFamiliar();
            //BuscarFamiliar(4);

        }
        /*
        // Crud Signo Vital 
        private static void AddSignoVital()
        {
            var Signo = new SignoVital
            {
                FrecuenciaCardiaca = 27,
                FrecuenciaRespiratoria = 130,
                Temperatura = 20
            };
            _repoSignoVital.AddSignoVital(Signo);
        }
        private static void BuscarSignoVital(int idSV)
        {
            var Signo = _repoSignoVital.GetSignoVital(idSV);
            Console.WriteLine(Signo.FrecuenciaCardiaca+ " " + Signo.FrecuenciaRespiratoria + " " + Signo.Temperatura);
        }
        public static void EliminarSignoVital(int idSV)
        {
            _repoSignoVital.DeleteSignoVital(idSV);
            Console.WriteLine("Se elimino la mascota con el id" + "" + idSV);
        }
        private static void ActualizarSignoVital(int idSV)
        {
            var SignoNuevo = new SignoVital
            {
                FrecuenciaCardiaca = 30,
                FrecuenciaRespiratoria = 30,
                Temperatura = 30
            };

            var SignoViejo = _repoSignoVital.GetSignoVital(idSV);
            SignoNuevo=SignoViejo;
            _repoSignoVital.UpdateSignoVital(SignoNuevo);
            Console.WriteLine("se actualizo la base de datos"+" "+SignoViejo.FrecuenciaCardiaca); 
        }
        private static void listaSignoVital()
        {
            var Signo = _repoSignoVital.GetAllSignoVital();
            foreach(var p in Signo)
            {
                var IdSV = p.Id;
                Console.WriteLine(IdSV);
            }
        }

        //Crud Sugerencia de Cuidado
        public static SugerenciaCuidado AddSugerenciaCuidado()
        {
            var SugerenciaC = new SugerenciaCuidado
            {
                Descripcion = "se recomienda collar",
                FechaHora = "enero 10:30"
            };
            Console.WriteLine("Se agrego la sugerencia de cuidado a la base de datos");
            _repoSugerenciaCuidado.AddSugerenciaCuidado(SugerenciaC);
            return SugerenciaC;
        }
        private static void BuscarSugerenciaCuidado(int idSC)
        {
            var Suge = _repoSugerenciaCuidado.GetSugerenciaCuidado(idSC);
            Console.WriteLine(Suge.Id+ " " + Suge.FechaHora + " " + Suge.Descripcion);
        }
        public static void EliminarSugerenciaCuidado(int idSC)
        {
            _repoSugerenciaCuidado.DeleteSugerenciaCuidado(idSC);
            Console.WriteLine("Se elimino la mascota con el id" + "" + idSC);
        }
        private static void ActualizarSugerenciaCuidado(int idSC)
        {
            var SC = new SugerenciaCuidado
            {
                Descripcion= "prueba",
                FechaHora = "prueba",
            };

            var SCV = _repoSugerenciaCuidado.GetSugerenciaCuidado(idSC);
            SCV=SC;
            _repoSugerenciaCuidado.UpdateSugerenciaCuidado(SCV);
            Console.WriteLine("se actualizo la base de datos"+" "+SCV.FechaHora); 
        }
        private static void listaSugerenciaCuidado()
        {
            var SC = _repoSugerenciaCuidado.GetAllSugerenciaCuidado();
            foreach(var p in SC)
            {
                var IdSC = p.Id;
                Console.WriteLine(IdSC);
            }
        }


        //Crud Historial
        public static void AddHistoria()
        {

            var sugerenci = new SugerenciaCuidado
            {
                Descripcion = "Tomar la temperatura prueba ",
                FechaHora = "prueba 2021-09-25 14:30 p. m.",
            };
            var Histori = new Historia
            {
                Diagnostico = 0,
                //SugerenciaCuidado = sugerenci,
            };
            Console.WriteLine("se agrego el histrial del paciente a la base de datos");
            _repoHistoria.AddHistoria(Histori);
        }
        private static void BuscarHistoria(int idHistoria)
        {
            var Histori = _repoHistoria.GetHistoria(idHistoria); 

            //Console.WriteLine(Histori.Diagnostico + " " + Histori.Id + " " + Histori.SugerenciaCuidado.Descripcion);
        }

        public static void EliminarHistoria(int idHistoria)
        {
            _repoHistoria.DeleteHistoria(idHistoria);
            Console.WriteLine("Se elimino la mascota con el id" + "" + idHistoria);
        }

        private static void listaHistoria()
        {
            var historia = _repoHistoria.GetAllHistorias();
            foreach(var p in historia)
            {
                var IdHisto = p.Id;
                Console.WriteLine(IdHisto);
            }
        }


        //Crud Mascota
        private static void AddMascota()

        {
             var Familiar = new FamiliarDesignado
            {
                Nombres = "Prueba",
                Apellidos = "Prueba",
                DocumentoIdentidad = "Prueba",
                Email = "Prueba",
            };
            var mascota = new Mascota
            {
                Nombre = "Lila",
                EstadoSalud = "Bien",
                Edad = 3,
                Genero = "Femenino",
                Raza = "pitbull",
                Direccion = "calle 35",
                Ciudad = "Medellin",
                Latitud = "20 567 10",
                Longitud = "189 38 12",
                TipoMascota = "Perro",
                //familiar=Familiar

            };
            Console.WriteLine(mascota.Nombre + "" + "fue agregado");
            _repoMascota.AddMascota(mascota);
        }
        private static void BuscarMascota(int idMascota)
        {
            var Mascota = _repoMascota.GetMascota(idMascota);
            Console.WriteLine(Mascota.Nombre + " " + Mascota.EstadoSalud );
        }
        public static void EliminarMascota(int idMascota)
        {
            _repoMascota.DeleteMascota(idMascota);
            Console.WriteLine("Se elimino la mascota con el id" + "" + idMascota);
        }

        private static void AddVeterinario()
        {
            var veterinario = new Veterinario
            {
                Nombres = "carlos mario",
                Apellidos = "zea null",
                DocumentoIdentidad = "12345678",
                TarjetaProfesional = "no tiene",
            };
            Console.WriteLine("veterinario creado");
            _repoVeterinario.AddVeterinario(veterinario);
        }
        private static void BuscarVeterinario(int idVetrinario)
        {
            var Veterinario = _repoVeterinario.GetVeterinario(idVetrinario);
            Console.WriteLine(Veterinario.Nombres + " " + Veterinario.Apellidos);
        }
        private static void AddFamiliar()
        {
            var signoV = new SignoVital
            {
                FrecuenciaCardiaca= 1,
                FrecuenciaRespiratoria= 1,
                Temperatura=1
            };
            var sugerenci = new SugerenciaCuidado
            {
                Descripcion = "Tomar la temperatura ",
                FechaHora = "2021-09-25 14:30 p. m.",
            };
            var Histori = new Historia
            {
                Diagnostico = 999999,
               // SugerenciaCuidado = sugerenci,
            };
            var mascota = new Mascota
            {
                Nombre = "Prueba",
                EstadoSalud = "Prueba",
                Edad = 5,
                Genero = "Prueba",
                Raza = "Prueba",
                Direccion = "Prueba",
                Ciudad = "Prueba",
                Latitud = "Prueba",
                Longitud = "Prueba",
                //TipoMascota = "Prueba",
                SignoVital = signoV,
                Historia = Histori
            };
            var familiar = new FamiliarDesignado
            {
                Nombres = "Prueba",
                Apellidos = "Prueba",
                DocumentoIdentidad = "Prueba",
                Email = "Prueba",
                Mascota = mascota
            };
            Console.WriteLine(familiar.Nombres + "" + "fue agregado");
            _repoFamiliar.AddFamiliar(familiar);
        }
        private static void BuscarFamiliar(int idFamiliar)
        {
            var Familiar = _repoFamiliar.GetFamiliar(idFamiliar);
            var d1=Familiar.Nombres;
            var d2=Familiar.Apellidos;
            var d3=Familiar.DocumentoIdentidad;
            var d4=Familiar.Email;
            //var d5=Familiar.Mascota.Id;
           // var d6=Familiar.Mascota.Nombre;
           // var d7=Familiar.Mascota.Historia.Id;
            //var d8 = Familiar.Mascota.SignoVital.Temperatura;

            Console.WriteLine(d1 + " " + d2 + " " + d3 + " " +d4 );
        }
        
        */



    }

}


