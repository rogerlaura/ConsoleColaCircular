using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleColaCircular
{
    internal class Cola
    {
        private int ultimo,primero,maxcola;
        private string[] items;
        public Cola(int maxcola)
        {
            this.ultimo = -1;
            this.primero = -1;
            this.maxcola= maxcola;
            this.items = new string[this.maxcola];
        }
        public bool colavacia()
        {
            if(this.ultimo == -1 && this.primero == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public  bool colallena()
        {
            if((this.ultimo==this.maxcola-1 && this.primero == 0) || this.ultimo+1 == this.primero)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
                                        //60
        public void InsertarItem(string dato)
        {
            if (this.colallena())
            {
                Console.WriteLine("LA COLA ESTA LLENA");
            }
            else
            {
                
                if (this.ultimo == this.maxcola - 1)
                {
                    this.ultimo = 0;


                }
                else
                {
                    
                    this.ultimo++;
                }
               
                this.items[this.ultimo] = dato;
                if (this.primero == -1)
                {
                    this.primero = 0;
                }
            }
        }

        public void EliminarItem()
        {
            if (this.colavacia())
            {
                Console.WriteLine("\tLA COLA ESTA VACIA");
            }
            else
            {
                Console.WriteLine("\tSE ELIMINO EL ELEMENTO " + this.items[this.primero]);
                this.items[this.primero] = "";
                if (this.primero == this.ultimo)
                {
                    this.primero = -1;
                    this.ultimo = -1;

                }
                else
                {
                    if (this.primero == this.maxcola - 1)
                    {
                        this.primero = 0;
                    }
                    else
                    {
                        //1+1=2
                        this.primero++;
                    }
                }
            }
        }
        public void ListarItems()
        {
            if (this.colavacia())
            {
                Console.WriteLine("\tLA COLA ESTA VACIA");
            }
            else
            {
                
                for (int i = 0; i < this.maxcola; i++)
                {
                    if (this.items[i]!=null)
                    {
                        Console.WriteLine("\t[" + i + "] => " + this.items[i]);
                    }
                    
                    
                    
                }
            }
        }
    }
}
