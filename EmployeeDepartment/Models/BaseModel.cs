namespace EmployeeDepartment.Models
{
    public abstract class BaseModel
    {
        public BaseModel()
        {
                this.IsActive = true;
        }
        public int Id { get; set; } 
        public bool IsActive { get; set; }    
    }
}