// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System
open EventStore.Client
open EventStore.ClientAPI.Embedded

// Define a function to construct a message to print
let from whom =
    sprintf "from %s" whom

let withEmbeddedEs() =
    async {

        // let factory = AuthenticationProviderFactory()

        let nodeBuilt =
            EmbeddedVNodeBuilder.AsSingleNode()
                                .OnDefaultEndpoints()
                                .RunInMemory()
                                .Build()

        ()    
    }

[<EntryPoint>]
let main argv =
    async {
        let message = from "F#" // Call the function
        printfn "Hello world %s" message

        do! withEmbeddedEs() 
        return 0 // return an integer exit code
    } |> Async.RunSynchronously