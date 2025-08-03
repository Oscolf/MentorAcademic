using SQLqueries;
using MySql.Data.MySqlClient;

namespace WinFormsMentorAcademic;
public class User 
{
    private string _idUser;
    private string _password;
    private string _email;
    private string _firstName;
    private string _lastName;
    private string _fullName;
    
    public User() { }

    public User(string nombre, string apellido, string email, string password)
    {
        Nombre = nombre;
        Apellido = apellido;
        Email = email;
        Password = password;
        Matricula = email;
    }

    public string Email
    {
        get { return _email; }
        set
        {
            int atCont = 0, dotCont = 0;
            for (int i = 0; i <= value.Length - 1; i++)
            {
                if (value[i] == '@')
                    atCont++;
                if (value[i] == '.')
                    dotCont++;
            }
            if (atCont != 1 || dotCont < 1)
                _email = "INVALID";
            else
            {
                _email = value;
                Matricula = value; // Matricula es derivado del email
            }

        }
    }
    public string Matricula
    {
        get { return _idUser; }
        set
        {
            string matr = "";
            for (int i = 0; i <= _email.Length - 1; i++)
            {
                if (value[i] == '@')
                    break;    
                matr += value[i];
            }
            _idUser = matr.ToUpper();
        }
    }
    public string Nombre
    {
        get { return _firstName; }
        set
        {
            if (value.Length <= 2)
            {
                _firstName = "INVALID";
                MessageBox.Show("Nombre demasiado corto, ingrese por lo menos 3 caracteres");
            }
            else
                _firstName = value;
            NombreCompleto = ValidateNaNFullName();
        }
    }
    public string Apellido
    {
        get { return _lastName; }
        set
        {
            if (value.Length <= 2)
            {
                _lastName = "INVALID";
                MessageBox.Show("Apellido demasiado corto, ingrese por lo menos 3 caracteres");
            }
            else
                _lastName = value;
            NombreCompleto = ValidateNaNFullName();
        }
    }
    public  string NombreCompleto
    {
        get { return _fullName; }
        set {_fullName = value; }
    }
    public string Password
    {
        get { return _password; }
        set
        {
            if (value.Length <= 6)
            {
                _password = "INVALID";
                MessageBox.Show("Contraseña demasiado corta, ingrese por lo menos 6 caracteres");
            }
            else
                _password = value;
        }
    }
    
    public bool ValidateSignUp()
    {
        if (_fullName == "INVALID")
        {
            MessageBox.Show("El nombre y/o apellido no pueden contener números");
            return false;
        }
        if (_password == "INVALID")
        {
            MessageBox.Show("La contraseña debe de tener por lo menos 6 caracteres");
            return false;
        }

        if (_email == "INVALID")
        {
            MessageBox.Show("El correo debe de tener un formato válido");
            return false;
        }
        
        SqlQueries signUpQueries = new SqlQueries("server=localhost;" +
                                                  "port=3306;" +
                                                  "database=mentoracademic;" +
                                                  "uid=root;" +
                                                  "sslmode=none;");
        
        string cmd = $"INSERT INTO alumnos (nombre, apellido, email, contasena, matricula) " +
                     $"VALUES ('{Nombre}', '{Apellido}', '{Email}', '{Password}', '{Matricula}');";
        
        signUpQueries.GetCommand_and_ExecuteNonQuery(cmd);
        return true;
    }

    public bool ValidateLogin()
    {
        SqlQueries loginQueries =  new SqlQueries("server=127.0.0.1;" +
                                                  "port=3306;" +
                                                  "database=mentoracademic;" +
                                                  "uid=root;" +
                                                  "sslmode=none;");
        
        string cmd = $"SELECT * FROM alumnos WHERE email = '{Email}' AND contasena = '{Password}';";
        
        MySqlDataReader reader = loginQueries.ExecuteReader(cmd);
        
        if (reader.Read())
        {
            Nombre = reader[1].ToString();
            Apellido = reader[2].ToString();
            Matricula = reader[3].ToString();
            Password = reader[4].ToString();
            
            MessageBox.Show($"Bienvenid@ {reader[1]}!");
        }
        else
        {
            MessageBox.Show("Usuario o contraseña incorrectos o inexistentes. Por favor, inténtelo de nuevo.");
            reader.Close();
            loginQueries.Get_Connection().Close();
            return false;
        }
        return true;
    }
    private string ValidateNaNFullName()
    {
        string name = _firstName + " " + _lastName;
        
        if (name == "INVALID INVALID")
            return "INVALID";
        
        for (int i = 0; i < name.Length; i++)
        {
            if (Char.IsDigit(name[i]))
            {
                MessageBox.Show("El nombre y apellido no pueden contener números");
                return "INVALID";
            }
        }
        return name;
    }
}