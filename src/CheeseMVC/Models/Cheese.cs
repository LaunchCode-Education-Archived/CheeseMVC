namespace CheeseMVC.Models
{
    public class Cheese
    {
        public string Name { get; set; }
        public string Description { get; set; }
        
        public int CheeseId { get; set; }
        private static int nextId = 1;

        public Cheese(string name, string description) : this()
        {
            Name = name;
            Description = description;
        }

        public Cheese()
        {
            CheeseId = nextId;
            nextId++;
        }

        // override object.Equals
        public override bool Equals(object obj)
        {

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            
            return CheeseId == (obj as Cheese).CheeseId;
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            return CheeseId;
        }
    }
}
