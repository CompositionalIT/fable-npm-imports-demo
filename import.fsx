#r "nuget: Fable.Core"

open Fable.Core
open Fable.Core.JsInterop

// Import the v4 function from the uuid package.
let [<Import("v4", from="uuid")>] uuidV4 : unit -> string = jsNative

// Use the imported uuidv4 function from F# to create a new UUID.
let myUuid = uuidV4()

// Print the result.
printfn $"Generated UUID: %s{myUuid}"

// Import lodash.
[<Import("default", "lodash")>]
let lodash: obj = jsNative

// Create two anonymous records (POJOs).
let obj1 = {| name = "Johan"; age = 30 |}
let obj2 = {| age = 31; city = "Nairobi" |}

// Merge the objects using lodash, from F#.
let merged : obj = lodash?merge obj1 obj2

// Print the result
JS.console.log merged

// Define an interface for the Lodash import.
type Lodash =
    abstract snakeCase: string -> string

// Import lodash, telling the compiler that _l matches the new interface.
[<Import("default", "lodash")>]
let _l: Lodash = jsNative

// Use the snakeCase function safely - the compiler checks that the usage
// is consitent with to the Lodash interface we declared.
let sc = _l.snakeCase "A sentence with some camelCase words."
JS.console.log sc

