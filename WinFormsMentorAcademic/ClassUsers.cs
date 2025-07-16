namespace WinFormsMentorAcademic;

public class User 
{
    private string _idUser;
    private string _password;
    private string _email;
    private string _firstName;
    private string _lastName;
    private string _fullName;
    
    public User()
    {
        _idUser = "placeholder";
        _password = "placeholder";
        _email = "placeholder";
        _firstName = "placeholder";
        _lastName = "placeholder";
        _fullName = "placeholder";
    }

    public User(string nombre, string apellido, string email, string password)
    {
        Nombre = nombre;
        Apellido = apellido;
        Email = email;
        Password = password;
        Matricula = email;
        NombreCompleto = ValidateNaNFullName();
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
                _email = value;
        }
    }
    public string Matricula
    {
        get { return _idUser; }
        set
        {
            string matr = "";
            for (int i = 0; i <= value.Length - 1; i++)
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
        bool verify = true;
  
        if (_fullName == "INVALID")
        {
            MessageBox.Show("El nombre y/o apellido no pueden contener números");
            verify = false;
        }
        if (_password == "INVALID")
        {
            MessageBox.Show("La contraseña debe de tener por lo menos 6 caracteres");
            verify = false;
        }

        if (_email == "INVALID")
        {
            MessageBox.Show("El correo debe de tener un formato válido");
            verify = false;
        }
        
        return verify;
    }

    public bool ValidateLogin()
    {
        bool verify = true;

        //Hacer una consulta a la base de datos para verificar si el usuario existe
        //si lo encuentra, regresa true, si no, false
        
        return verify;
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