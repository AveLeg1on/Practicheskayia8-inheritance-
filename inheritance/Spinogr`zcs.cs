using System;
using System.Windows;

namespace inheritance
{
    internal class Spinogr_zcs : Father
    {
        public int CompareTo(object obj)
        {
            Father other = (Father)obj;
            if (this.SureName != other.SureName) return 1;
            if (this.SureName == other.SureName) return 0; //Вася Пупкин Петрович
            return -5;
        }
        
        public bool PrintName(string FIO, out string name)
        {
            Father father = new Father();
            bool perem;

            int s1 = 0, s2 = 0, s3 = 0, index = 0;
            FIO = FIO + " ";
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
            }
            s1 = SecondName.LastIndexOf('й');
            s2 = SecondName.LastIndexOf('и');
            if (s1 > 0)
            {
                if (s2 > 0)
                {
                    
                    index = SecondName.LastIndexOf('и');
                    SecondName = SecondName.Remove(index, 1);
                    index = SecondName.LastIndexOf('й');
                    SecondName = SecondName.Remove(index, 1);
                    SecondName += "ьевич";
                    father.SecondName = SecondName;
                }
                else
                {
                    index = SecondName.LastIndexOf('й');
                    SecondName = SecondName.Remove(index, 1);
                    SecondName += "евич";
                    father.SecondName = SecondName;
                }

            }
            else
            {
                father.SecondName = SecondName + "ович";
            }


            name = _name + " " + father.SecondName;
            //name = _name +" "+ _secondName ;
            return perem=false;
        }

        public object Clone()
        {
            Father OTHER = new Father();
            OTHER.Name = this.Name;
            OTHER.SecondName = this.SecondName;
            OTHER.SureName = this.SureName;
            return OTHER;
        }
        public Father ShadowClone()
        {
            return (Father)MemberwiseClone();
        }
    }
}
