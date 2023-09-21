using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class User
    {
        // Fields
        private String username;
        private String password;
        private String name;
        private String family;
        private int id;

        // Methods
        // Constructor

        public User(String username, String password, String name, String family, int id)
        {
            setUsername(username);
            setPassword(password);
            setName(name);
            setFamily(family);
            setId(id);
        }
        // Default Constructor
        public User()
        {
            setUsername("test");
            setPassword("test");
            setName("test");
            setFamily("test");
            setId(1);

        }
        // Setter Methodes
        public void setUsername(string userName)
        {
            this.username = userName;
        }
        public void setPassword(string password)
        {
            this.password = password;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setFamily(string family)
        {
            this.family = family;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        // Getter Methods
        public String getUsername()
        {
            return this.username;
        }
        public String getPassword()
        { 
            return this.password;
        }
        public String getName()
        {
            return this.name;
        }
        public String getFamily() 
        {
            return this.family;
        }
        public int getId() 
        {
            return this.id;
        }
        // to String
        public String toString()
        {
            return getName() + " " + getFamily() + " " + getUsername() + " " + getPassword() + " " + getId();
        }
    }
}
