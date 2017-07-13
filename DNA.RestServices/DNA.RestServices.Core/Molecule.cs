using System;
using System.Collections.Generic;
using System.Text;

namespace DNA.RestServices.Core
{
    public class MoleculeType
    {
        public const string ResourceMolecule = "ResourceMolecule";
    }


    public class Molecule
    {
        public Molecule(string type)
        {
            this.Type = type;
        }

        public string Type { get;  private set; }
    }

    public class UIMolecule : Molecule
    {

    }

    public class TextMolecule : UIMolecule
    {

    }

    public class InputMolecule : UIMolecule
    {

    }

    public class ImageMolecule : UIMolecule
    {

    }

    public class ResourceMolecule : Molecule
    {
        public ResourceMolecule():base(MoleculeType.ResourceMolecule)
        {

        }

        public string Key { get; set; }
        public long UTCTimestamp { get; set; } 
        public string Culture { get; set; }
    }
}
