using System;
using System.Collections.Generic;
using System.Text;

namespace DNA.RestServices.Core
{
    public static class MoleculeType
    {
        public static string ResourceMolecule => nameof(ResourceMolecule);

        public static string UIMolecule => nameof(UIMolecule);

        public static string ValidateMolecule => nameof(ValidateMolecule);
    }

    public static class UiMoleculeType
    {
        public static string TextMolecule => nameof(TextMolecule);
        public static string ImageMolecule => nameof(ImageMolecule);
        public static string InputMolecule => nameof(InputMolecule);
    }

    public static class ValidateMoleculeType
    {
        public static string RequiredMolecule => nameof(RequiredMolecule);
    }



    public class Molecule
    {
        public Molecule(string type)
        {
            this.Type = type;
        }

        public string Type { get;  private set; }
    }

    public class UiMolecule : Molecule
    {
        public string UiType { get; private set; }

        public UiMolecule(string type) : base(Core.MoleculeType.UIMolecule)
        {
            UiType = type;
        }
    }

    public class TextMolecule : UiMolecule
    {
        public ResourceMolecule TextResource { get; set; }

        public TextMolecule():base(Core.UiMoleculeType.TextMolecule)
        {

        }
    }

    public class InputMolecule : UiMolecule
    {
        public ResourceMolecule PlaceholderResource { get; set; }

        public InputMolecule():base(Core.UiMoleculeType.InputMolecule)
        {

        }
    }

    public class ImageMolecule : UiMolecule
    {
        public ResourceMolecule ImageResource { get; set; }

        public ImageMolecule():base(Core.UiMoleculeType.ImageMolecule)
        {

        }
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

    public class ValidateMolecule : Molecule
    {
        public string ValidateType { get; private set; }

        public ValidateMolecule(string type) : base(MoleculeType.ValidateMolecule)
        {
            ValidateType = type;
        }
    }

    public class RequiredMolecule : ValidateMolecule
    {
        public RequiredMolecule() : base(ValidateMoleculeType.RequiredMolecule)
        {
        }
    }
}
