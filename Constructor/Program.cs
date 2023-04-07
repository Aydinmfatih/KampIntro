
Customer customer1= new Customer() { Id=2,Email="asd",Name="fatih",Phone="1123123"};
Customer customer2= new Customer(2,"esra","ayşe","1234123");

Console.WriteLine(customer2.Name);
class Customer
{
    public Customer()
    {
            
    }
    
    public Customer(int id, string email,string name ,string phone)
    {
        Id = id;    
        Name = name;
        Email= email;
        Phone= phone;


    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
}