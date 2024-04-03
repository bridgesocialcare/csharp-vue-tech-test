# Patient Referral System

This repository contains a simple patient referral system consisting of a Vue web app and a .NET API. Currently most of its functionality does not exist - the Vue web app has no functionality and the API only has a single endpoint.
 
## Setup instructions

### Creating a GitHub codespace

The repository includes a GitHub Codespaces configuration to avoid development environment setup. To create a codespace:

1. Ensure you are signed in with a GitHub account (free GitHub accounts receive 120 monthly core hours of Codespaces usage)
2. Click on the Code dropdown -> Codespaces -> Create codespace on main
3. Wait whilst the codespace is created and the VS Code extensions are installed. This should only take a minute.
4. Make sure to delete the codespace once done as closing the tab does not delete it. You may need to refresh [the page](https://github.com/bridgesocialcare/csharp-vue-tech-test) before you can see the codespace to delete it.

### Running the Vue App

To run the Vue app:

1. In the terminal, change directory to `/frontend`
2. Run `npm install` to install the app's dependencies
3. Run `npm run dev` to start the app.

### Running the .NET API

To run the .NET API:

1. Open `Program.cs`
2. Click on the debug button in the top right of the screen to start the API. This should open a new tab with the address `https://<<YOUR CODEBASE AND PORT>>.app.github.dev`
3. Navigate to `https://<<YOUR CODEBASE AND PORT>>.app.github.dev/swagger`. From here, you should be able to test out the existing endpoint.
