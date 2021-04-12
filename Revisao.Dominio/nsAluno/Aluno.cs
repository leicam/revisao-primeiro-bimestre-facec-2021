using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Dominio.nsAluno
{
    public class Aluno
    {
        private const uint _frequenciaMaxima = 45;
        private const uint _toleranciaFaltas = 9;

        public uint RegistroAcademico { get; private set; }
        public string Nome { get; private set; }
        public uint Frequencia { get; private set; }
        public decimal NotaPrimeiroBimestre { get; private set; }
        public decimal NotaSegundoBimestre { get; private set; }

        public Aluno(uint registroAcademico, string nome, uint frequencia, decimal notaPrimeiroBimestre, decimal notaSegundoBimestre)
        {
            RegistroAcademico = registroAcademico;
            Nome = nome ?? throw new ArgumentNullException(nameof(Aluno));
            Frequencia = frequencia;
            NotaPrimeiroBimestre = notaPrimeiroBimestre;
            NotaSegundoBimestre = notaSegundoBimestre;

            ValidarFrequencia();
            ValidarNotaPrimeiroBimestre();
            ValidarNotaSegundoBimestre();
        }

        public bool IsAlunoFicouParaExame()
        {
            return ((NotaPrimeiroBimestre + NotaSegundoBimestre) / 2) < 7;
        }

        public bool IsAlunoReprovadoPorFaltas()
        {
            return Frequencia < (_frequenciaMaxima - _toleranciaFaltas);
        }

        private void ValidarFrequencia()
        {
            if (Frequencia > _frequenciaMaxima)
                throw new ArgumentOutOfRangeException(nameof(Frequencia));
        }

        private void ValidarNotaPrimeiroBimestre()
        {
            if (NotaPrimeiroBimestre < 0.00m)
                throw new ArgumentOutOfRangeException(nameof(NotaPrimeiroBimestre));
        }

        private void ValidarNotaSegundoBimestre()
        {
            if (NotaSegundoBimestre < 0.00m)
                throw new ArgumentOutOfRangeException(nameof(NotaSegundoBimestre));
        }
    }
}