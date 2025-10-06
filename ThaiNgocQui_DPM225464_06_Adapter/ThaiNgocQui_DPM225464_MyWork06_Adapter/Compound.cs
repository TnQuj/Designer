using System;

namespace ThaiNgocQui_DPM225464_MyWork06_Adapter
{
    public class Compound
    {
        public Chemical Chemical { get; protected set; }
        public float BoilingPoint { get; protected set; }
        public float MeltingPoint { get; protected set; }
        public double MolecularWeight { get; protected set; }
        public string MolecularFormula { get; protected set; }  // bỏ dấu ?

        public virtual void Display()
        {
            Console.WriteLine("\nCompound: Unknown ------ ");
        }
    }
}
