namespace AboutCard_MVC.Models
{
	public class Articles
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Client { get; set; }

        public Articles(int id,string name,string description,string image,string client)
        {
            Id = id;
            Name = name;
            Description = description;
            Image = image;
            Client = client;
        }
    }
}
