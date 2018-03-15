namespace StoreOfBuild.Domain.Products
{
    public class Category : Entity
    {
        //nao precisa mais pois ja herda de entity
        //public int Id { get; private set; }
        public string Name { get; private set; }


        public Category(string name)
        {
            ValidateNameAndSetName(name);
            
        }       

        public void Update(string name)
        {
            ValidateNameAndSetName(name);
        }

        private void ValidateNameAndSetName(string name)
        {
            DomainException.When(!string.IsNullOrEmpty(name), "Name é obrigatório");
            DomainException.When(!(name.Length < 3), "Name nao pode ter menos que 3 caracteres");
            Name = name;
        }

        
    }
}