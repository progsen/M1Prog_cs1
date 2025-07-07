
namespace MenuDraw
{
    class Equipment
    {
        public string name;
        public EquipmentType type;
        public Bitmap image;

        public Equipment(string name, EquipmentType type)
        {
            this.name = name;
            this.type = type;
            this.image = new Bitmap(name + ".PNG");
        }

    }
}
