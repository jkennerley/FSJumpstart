module fsharp_records




// Records :: easy syntax light way of passing around data

//*********
// type X        // type keyword
// type X =      // the = 
// type X = {}   // the brackets
// list the properties of the type 
// the types of each property after the :
type Person = 
    {
        Surname:string 
        Forename:string
    }

type Customer = 
    {
        SName:string 
        FName:string
    }

//type string100 = {v:string}

type Contact = 
    {
        SName:string 
        FName:string
    }


type Packet<'a> = 
    { 
        status:int 
        model:'a
    } 

//*********
// creat e type  ; let instanceName = 
// new is not ncessary
// new X() is not ncessary
// curlys contain the preporties {...}
let person1 = {Surname="Smith" ; Forename="John" }
let person2 = {Person.Surname="Smith2" ; Forename="John" }


//*********
// modifying, DONT ;  create a new instance and modify some of the field values using keyword with
// person2
let person3 = { person2 with Forename = "XXXX"}

//*********
// generic types
let packet1 = { status=0 ; model="fred"  }

let packet2 = { status=0 ; model = { Surname= "Smith" ; Forename="John"}  }

//*********
// recods have structural equality, 

let p1 = {Surname="A" ; Forename="B"}
let p2 = {Surname="A" ; Forename="B"}
let p3 = {Surname="A" ; Forename="b"}

// structural/content equality
p1 = p2
p1 = p3
















