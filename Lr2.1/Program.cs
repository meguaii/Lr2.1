using System;

namespace ClassroomApp
{

    class Pupil
    {
        public virtual void Study() => Console.WriteLine("Pupil studies.");
        public virtual void Read() => Console.WriteLine("Pupil reads.");
        public virtual void Write() => Console.WriteLine("Pupil writes.");
        public virtual void Relax() => Console.WriteLine("Pupil relaxes.");
    }

    class ExcelentPupil : Pupil
    {
        public override void Study() => Console.WriteLine("Excellent pupil studies.");
        public override void Read() => Console.WriteLine("Excellent pupil reads books.");
        public override void Write() => Console.WriteLine("Excellent pupil writes.");
        public override void Relax() => Console.WriteLine("Excellent pupil relaxes.");
    }

    class GoodPupil : Pupil
    {
        public override void Study() => Console.WriteLine("Good pupil studies.");
        public override void Read() => Console.WriteLine("Good pupil reads with.");
        public override void Write() => Console.WriteLine("Good pupil writes.");
        public override void Relax() => Console.WriteLine("Good pupil relaxes.");
    }

    class BadPupil : Pupil
    {
        public override void Study() => Console.WriteLine("Bad pupil studies.");
        public override void Read() => Console.WriteLine("Bad pupil reading.");
        public override void Write() => Console.WriteLine("Bad pupil writes.");
        public override void Relax() => Console.WriteLine("Bad pupil relaxes.");
    }



    class ClassRoom
    {
        private Pupil[] pupils;

        public ClassRoom(params Pupil[] pupils)
        {
            if (pupils.Length > 4)
            {
                throw new ArgumentException("ClassRoom can only have up to 4 pupils.");
            }

           
            this.pupils = new Pupil[4];
            for (int i = 0; i < pupils.Length; i++)
            {
                this.pupils[i] = pupils[i];
            }
            for (int i = pupils.Length; i < 4; i++)
            {
                this.pupils[i] = new Pupil(); 
            }
        }

        
        public void ShowPupilsInfo()
        {
            for (int i = 0; i < pupils.Length; i++)
            {
                Console.WriteLine($"Pupil {i + 1}:");
                pupils[i].Study();
                pupils[i].Read();
                pupils[i].Write();
                pupils[i].Relax();
                Console.WriteLine();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Pupil excellentPupil = new ExcelentPupil();
            Pupil goodPupil = new GoodPupil();
            Pupil badPupil = new BadPupil();

        
            ClassRoom classRoom = new ClassRoom(excellentPupil, goodPupil, badPupil);

            classRoom.ShowPupilsInfo();
        }
    }
}
