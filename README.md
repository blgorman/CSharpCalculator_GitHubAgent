# Creating a Robust C# Program with Copilot agent At GitHub

Follow the instructions on this readme to Create a C# Console App using GitHub Copilot Only from an application shell with GitHub Copilot using issues and pull request reviews.

## Using VSCode

If you would like to see a similar solution using VS Code [Check Out This Repo](...)  

## Prerequisites

Set up a repo at GitHub and clone it locally (establishes main branch upstream tracking).  Give it a Visual Studio .gitignore, a README.md and a license of choice. 

Do not add any code, but make sure that you have cloned the repo locally so that you can add code to it easily. 

>**Note**: It is likely you would have been able to start this entire project from scratch entirely using issues.  For simplicity, this demo sets a project shell in place so that the walkthrough can progress easily.  

## Instructions

Ensure that you have a local cloned repository before beginning.  Once that is in place, follow these instructions to let GitHub Copilot Agent work its magic on your repository.

1. Create a feature branch

    ```git
    git switch -c 1-intial-work-yourname
    ```  

1. Add the code

    Add the code found in the `./Starter/Starter.zip` file to the repo. This will stub in the project shell.  **Ensure that the code runs as expected from your local machine before pushing to GitHub.**

    Once you have the start code in place, push it to GitHub.  Once the code is in GitHub, open your browser to the repo to proceed.

    The Repo should look like this:

    |- CSharpCalculator  
    |    |- CSharpCalculator.csproj  
    |    |- ConfigurationBuilderSingleton.cs  
    |    |- Program.cs  
    |    |- appsettings.json  
    |    |- secrets_example.json  
    |- Operations.Tests  
    |    |- OperationsTests.csproj  
    |    |- TestValidation.cs  
    |- Operations  
    |    |- Operations.csproj  
    |    |- Validation.cs  
    |- .gitignore  
    |- CSharpCalculator.sln  
    |- LICENSE  
    |- README.md  

1. Create an issue

    Open the github repo and add an issue.  Place the following markdown in the issue

    ```markdown

    ```  



