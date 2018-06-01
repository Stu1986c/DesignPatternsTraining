namespace DesignPatterns.FSharpNull

module NullCheck =

    type Person = { FirstName : string; LastName : string }

    let getFullName (person:Option<Person>) =
      match person with
      | Some(person) -> person.FirstName + " " + person.LastName
      | None -> "There is no Person. Do something useful here"


//let myPerson = {FirstName = "John"; LastName = "Smith"}