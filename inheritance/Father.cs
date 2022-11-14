using System.Windows;

namespace inheritance
{
    internal class Father
    {
        protected string _name, _secondName, _sureName;
        public Father()
        {
            _name = " ";
            _secondName = " ";
            _sureName = " ";
        }
        //public Father(string name, string secondName, string sureName)
        //{
        //    Name = name;
        //    SecondName = secondName;
        //    SureName = sureName;
        //}

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string SecondName
        {
            get
            {
                return _secondName;
            }
            set
            {
                _secondName = value;
            }
        }
        public string SureName
        {
            get
            {
                return _sureName;
            }
            set
            {
                _sureName = value;
            }
        }




        public bool PrintName(string FIO, out string name)
        {
            bool perem;
            int s1, s2, s3;

            FIO += " ";
            s1 = FIO.IndexOf(' ');
            SureName = FIO.Substring(0, s1);
            FIO = FIO.Substring(s1 + 1);
            if (FIO.StartsWith(' '))
            {
                MessageBox.Show("А так нельзя!!!!!!!!!!");

                name = " ";
                perem = true;
                return perem;
            }
            else
            {
                s2 = FIO.IndexOf(' ');
                Name = FIO.Substring(0, s2);
                FIO = FIO.Substring(s2 + 1);
                if (FIO.StartsWith(' '))
                {
                    MessageBox.Show("А так нельзя!!!!!!!!!!");

                    name = " ";
                    perem = true;
                    return perem;
                }
                else
                {
                    s3 = FIO.IndexOf(' ');
                    SecondName = FIO.Substring(0, s3);
                    name = _name;
                    return perem = false;
                }

            }

        }
    }
}
