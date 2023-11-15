using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResenyasPeliculas
{
    internal class Resenya
    {
        public string Titulo { get; set; }
        public double Nota { get; set; }
        public int Anyo {  get; set; }
        public string Contenido {  get; set; }
        public bool Recomendado { get; set; }
        public string Generos {  get; set; }
        public string ImagenPath { get; set; }
        public char Tipo {  get; set; }

        public Resenya(
            char tipo, 
            string titulo,
            int anyo, 
            string generos,
            double nota,
            string contenido,
            bool recomendado,
            string imagenPath
        ) 
        { 
            this.Tipo = tipo;
            this.Titulo = titulo;
            this.Anyo = anyo;
            this.Generos = generos;
            this.Nota = nota;
            this.Contenido = contenido;
            this.Recomendado = recomendado;
            this.ImagenPath = imagenPath;
        }

        public static Resenya cargarResenya(BinaryReader br)
        {
            char tipo = br.ReadChar();
            string titulo = br.ReadString();
            int anyo = br.ReadInt32();
            string generos = br.ReadString();
            double nota = br.ReadDouble();
            string contenido = br.ReadString();
            bool recomendado = br.ReadBoolean();
            string imagenPath = br.ReadString();

            return new Resenya(
                tipo,
                titulo,
                anyo, 
                generos,
                nota,
                contenido, 
                recomendado,
                imagenPath
            );
        }

        public void guardarResenya(BinaryWriter bw)
        {
            bw.Write(Tipo);
            bw.Write(Titulo);
            bw.Write(Anyo);
            bw.Write(Generos);
            bw.Write(Nota);
            bw.Write(Contenido);
            bw.Write(Recomendado);
            bw.Write(ImagenPath);
        }

    }
}
