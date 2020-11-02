using System;
using System.Collections.Generic;

public class draft2
{
    
    
    public abstract class Animal
    {
        //variable for class and type
        private string _class;
        private string _oftype;
        
        //Get class of animal
       public void getclass(string classes)
       {
           _class = classes;
       }
       
        //Get type of animal
       public void oftype(string types)
       {
           _oftype=types;
       }
       
       private string _name;
       public void getname(string name)
       {
           _name=name;
           Console.WriteLine($"{_oftype} Animal name is {name}");
       }
       private int _nolegs;
       public void Anolegs (int nolegs)
       {
           _nolegs=nolegs;
       }
       
       
       public bool CanSwim{get; set;}
       
       public abstract void GetClass();
       public abstract void OfType();
       //if has legs or not
       public bool HasLegs() => _nolegs > 0;
       public string Getnames() => _name;
    }
    

    // class for Amphibian
    public class Amphibian : Animal 
    {
     public override void GetClass()
     {
         getclass("amphibia");
     }
     public override void OfType()
     {
         oftype("amphibian");
         Anolegs(4);
         
     }
    }
    
    public interface Iamphibian
    {
        void fourLimbed();
        void coldBlooded();
    }
    
    public class Frog : Amphibian, Iamphibian, filterName
    {
        public void fourLimbed()
        {
            Console.WriteLine("");
        }
        public void coldBlooded()
        {
            Console.WriteLine("");
        }
        public void pangalan()
       {
           OfType();
           getname("froggy");
       }
        
    }
    public class Salamander : Amphibian, Iamphibian, filterName
    {
        public void fourLimbed()
        {
            Console.WriteLine("");
        }
        public void coldBlooded()
        {
            Console.WriteLine("");
        }
        public void pangalan()
       {
           OfType();
           getname("sander");
       }
    }
    
    
    
    
    
    
    // class for Mammal
    public class mammal : Animal 
    {
     public override void GetClass()
     {
         getclass("mammalia");
     }
     public override void OfType()
     {
         oftype("mammal");
     }
    }
    
    public interface Imammal
    {
        void neocortex();
        void hair();
    }
    
    public class Bats : mammal, Imammal, filterName
    {
        public void neocortex()
        {
            Console.WriteLine("");
        }
        public void hair()
        {
            Console.WriteLine("");
        }
        public void pangalan()
       {
           OfType();
           getname("batsie");
       }
    }
    public class human : mammal, Imammal, filterName
    {
        public void neocortex()
        {
            Console.WriteLine("");
        }
        public void hair()
        {
            Console.WriteLine("");
        }
        public void pangalan()
       {
           OfType();
           getname("john");
       }
       
    }
    
    
    
    
    // class for Bird
    public class Bird : Animal 
    {
     public override void GetClass()
     {
         getclass("aves");
     }
     public override void OfType()
     {
         oftype("bird");
     }
    }
    
    public interface Ibird
    {
        void feather();
        void toothless();
    }
    
    public class Eagle : Bird, Ibird, filterName
    {
        public void feather()
        {
            Console.WriteLine("");
        }
        public void toothless()
        {
            Console.WriteLine("");
        }
        public void pangalan()
       {
           OfType();
           getname("alex");
       }
    }
    public class Dove : Bird, Ibird, filterName
    {
        public void feather()
        {
            Console.WriteLine("");
        }
        public void toothless()
        {
            Console.WriteLine("");
        }
        public void pangalan()
       {
           OfType();
           getname("dave");
       }
    }
    
    
    
    
    
    
    // class for reptile
    public class Reptile : Animal 
    {
     public override void GetClass()
     {
         getclass("reptilia");
     }
     public override void OfType()
     {
         oftype("reptile");
     }
    }
    
    public interface Ireptile 
    {
        void fourLimbed();
        void coldBlooded();
    }
    
    public class Crocodile : Reptile, Ireptile, filterName
    {
        public void fourLimbed()
        {
            Console.WriteLine("");
        }
        public void coldBlooded()
        {
            Console.WriteLine("");
        }
        public void pangalan()
       {
           OfType();
           getname("lolong");
       }
    }
    public class Snake : Reptile, Ireptile, filterName
    {
        public void fourLimbed()
        {
            Console.WriteLine("");
        }
        public void coldBlooded()
        {
            Console.WriteLine("");
        }
        public void pangalan()
       {
           OfType();
           getname("snaky");
       }
        
    }
    
    
    
    
    
    // class for fishes
    public class fishes : Animal 
    {
     public override void GetClass()
     {
         getclass("anatidae");
     }
     public override void OfType()
     {
         oftype("fishes");
     }
    }
    
    public interface Ifishes
    {
        void aquatic();
        void nolimbsdigit();
    }
    
    public class Goldfish : fishes, Ifishes, filterName
    {
        public void aquatic()
        {
            Console.WriteLine("");
        }
        public void nolimbsdigit()
        {
            Console.WriteLine("");
        }
        public void pangalan()
       {
           OfType();
           getname("goldy");
       }
    }
    public class Shark : fishes, Ifishes, filterName
    {
        public void aquatic()
        {
            Console.WriteLine("");
        }
        public void nolimbsdigit()
        {
            Console.WriteLine("");
        }
        public void pangalan()
       {
           OfType();
           getname("sharky");
       }
    }
    
    
    public interface filterName
    {
       void pangalan();
    }
    
    
    static public void Main ()
    {
       
       List<Animal> list = new List<Animal>();
       
       fishes gold = new Goldfish();
       fishes shark = new Shark();
       
      Reptile crocodile = new Crocodile();
       Reptile snake = new Snake();
       
       Bird eagle = new Eagle();
       Bird dove = new Dove();
       
       mammal bats = new Bats();
       mammal human = new human();
       
      Amphibian frog = new Frog();
       Amphibian salamander = new Salamander();
       
       list.Add(gold);
       list.Add(shark);
       list.Add(crocodile);
       list.Add(snake);
       list.Add(eagle);
       list.Add(dove);
       list.Add(bats);
       list.Add(human);
       list.Add(frog);
       list.Add(salamander);
     
       
       
       foreach(filterName b in list)
       {
           if(b is Goldfish || b is Shark || b is Eagle || b is Dove || b is Bats || b is human)
           b.pangalan();
       }
    }

}
