# C#6 Programming with Visual Studio 2015
Repo holding the exercises from the book.

## Chapter 1: Introducing C# 
<ol>
	<li><b>Mono</b> is an open source version of the .NET Framework (including a C# Compiler) that runs on several operating systems, including various flavors of Linux and Mac OS.
		<ul>
			<li>You can read more about it at http://www.mono-project.com</li>
			<li>There are also variants of Mono that urn on iPhone (MonoTouch) and Android(Mono for Android, aka MonoDroid)</li>
		</ul>
	</li>
	<li>Part of the .NET Framework library defines some basic types, and by specifying fundamental types, the Framework facilitates interoprability between languages using the .NET Framework.
		<ul>
			<li>This is called the <b>Common Type System(CTS)</b></li>
		</ul>		
	</li>
	<li>The .NET Framework also includes the <b>Common Language Runtime(CLR)</b>.
		<ul>
			<li>The CLR is responsible for the execution of all applications developed using the .NET library</li>
		</ul>		
	</li>
</ol>


<ol>
	<li></li>
</ol>

<ul>
	<li>
	</li>
</ul>













# ASP .NET practice
Repo holding a simple ASP .NET MVC app to experiment with various C# functions


### Step 1: Create git repo and check in project
<ol>
  <li>Created new git repo </li>
  <li>Clone this repo into a local directory that VS will be creating the new .NET project within
    <ul>
      <li>I created a new directory to hold my new git repo on my local </li>
      <li>I created the new directory at C:\Users\Deeze814\Source\Repos </li>
    </ul>
  </li>
  <li>I then Shift+Right Click to open a git bash terminal in this directory and issued the commands
    <ul>
      <li>git clone https://github.com/DennisEzell/DotNET_practice.git
        <ul>
          <li>This will create a new folder in the Dashboard directory named after the repo being cloned</li>
          <li>Results in a path of C:\Users\Deeze814\Source\Repos\DotNET_practice\</li>
        </ul>
      </li>      
    </ul>
  </li>
  <li>Then I opened Visual Studios and performed the following steps:
    <ul>
      <li>Click File --> New --> Project</li>
      <li>Popup Left Menu:   Templates --> Visual C#</li>
      <li>Popup Right Menu:  ASP.NET Web Application</li>
      <li>Popup Bottom Menu: Following values-->
          <ul>
            <li>Name:           Dashboard</li>
            <li>Location:       C:\Users\Deeze814\Source\Repos\DotNET_practice\</li>
            <li>Solution:       Create new Solution</li>
            <li>Solution Name:  Dashboard</li>
          </ul>
      </li>
      <li>On the next screen I selected the MVC option</li>
    </ul>
  </li>
  <li>Open Git bash and path down into the cloned repo location (C:\Users\Deeze814\Source\Repos\DotNET_practice)</li>
  <li>Run the following Git commands
    <ul>
      <li>$ git pull</li>
      <li>$ git add *</li>
      <li>$ git commit -m "Initial commit of C# project"</li>
      <li>$ git push</li>
    </ul>
  </li>
</ol>