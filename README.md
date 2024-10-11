# Fable imports demo

- Run `dotnet tool restore` to install fable as a repository-local dotnet tool.
- Run `npm install` to install npm packages.
- Run `dotnet fable watch import.fsx --sourceMaps --run npx vite` to:
  - Transpile the code in import.fsx into import.fs.js, which is referred to from index.html (`dotnet fable import.fsx`).
  - Have Fable automatically recompile when import.fsx is updated (`watch`).
  - Generate `import.fs.js` so that you can add breakpoints to your F# code in the browser (`--sourceMaps`)!
  - Serve the assets from a local vite dev server once Fable compilation is finished (`--run npx vite`).

Note: we'd usually make an F# project for production code. Check out the [Feliz template](https://www.nuget.org/packages/Feliz.Template/#readme-body-tab) (client-side only) or [SAFE template](https://safe-stack.github.io/docs/quickstart/#create-your-first-safe-app) (full stack) for more complete templates to kickstart your journey.
