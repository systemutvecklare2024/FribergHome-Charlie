namespace FribergHome_API.Models
{
	public class PropertyImage
	{
		public int Id { get; set; }
		public string ImgURL { get; set; }
		public virtual Property Property { get; set; }
		public int PropertyId { get; set; }
	}
}
