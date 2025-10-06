using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThaiNgocQui_DPM225464_Real06_Adapter
{
    public class RichCompound : Compound
    {
        private string chemical;
        private ChemicalDatabank bank;

        public RichCompound(string chemical)
        {
            this.chemical = chemical;
        }

        public override void Display()
        {
            bank = new ChemicalDatabank();
            boilingPoint = bank.GetCriticalPoint(chemical, "B");
            meltingPoint = bank.GetCriticalPoint(chemical, "M");
            molecularWeight = bank.GetMolecularWeight(chemical);
            molecularFormula = bank.GetMolecularStructure(chemical);

            Console.WriteLine($"\nCompound: {chemical} ------");
            Console.WriteLine($" Formula: {molecularFormula}");
            Console.WriteLine($" Weight : {molecularWeight}");
            Console.WriteLine($" Melting Pt: {meltingPoint}");
            Console.WriteLine($" Boiling Pt: {boilingPoint}");
        }
    }
}
