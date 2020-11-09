using System;
namespace WinnersCirlce.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }  //look up user roles need 1 admin users will request square and calls for square will be sent to admin, reg users can only see avaiable


        public Users()
        {
        }
    }
}
