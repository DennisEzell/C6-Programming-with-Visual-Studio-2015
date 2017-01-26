# C#6 Programming with Visual Studio 2015 - Bejamin Perkins, Jacob Vibe Hammer, Jon D. Reid
Repo holding notes and exercises from the book.

## Chapter 1: Introducing C# 
### What is the .NET Framework?
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
### Writing Applications Using the .NET Framework
<ol>
	<li>In order for C# code to execute, it must be converted into a langauge that the target operating system understands, known as <b>native code</b></li>
		<ul>
			<li>This conversion is called <b>compiling</b> code, an act that is performed by a compiler.</li>
			<li>Under the .NET Framework, this is a two stage process</li>
		</ul>
	<li>When you compile code that uses the .NET Framework library, you don't immediately create operating system specific code.
		<ul>
			<li>Instead you Compile code into <b>Common Intermediate Language(CIL)</b> code
				<ul>
					<li>This code isnt specific to any operating system and isnt specific to C#</li>
					<li>This compilation step is carried out by Visual Studio when you develope C# applications</li>
				</ul>
			</li>
			<li>More work is required to execute an application, and that is the job of a <b>just-in-time(JIT)</b> compiler
				<ul>
					<li>The JIT compiles CIL into native code tht is specific to the OS and machine architecture being targeted.</li>
				</ul>
			</li>
		</ul>
	</li>
	<li>You might come across references to <b>Microsoft Intermediate Language(MSIL)</b> or just IL.
		<ul>
			<li>MSIL was the original name for CIL, and many developers still used this terminology.</li>
			<li><b>MSIL == CIL</b></li>
		</ul>
	</li>	
</ol>
### Assemblies
<ol>
	<li>When you compile and application, the CIL code is stored in an <b>assembly</b>
		<ul>
			<li>Assemblies included both:
				<ul>
					<li>Executable application files that you can run directly on Windows without the need for any programs</li>
					<li>These have a <b>.exe</b> file extension</li>
				</ul>
				<ul>
					<li>Libraries for use by other applications</li>
					<li>These have a <b>.dll</b> extension</li>
				</ul>
			</li>
		</ul>
	</li>
	<li>If you write code that performs tasks required by multiple applications, you want to place the reusable code in a place accessible by all the applications
		<ul>
			<li>In the .NET Framework, this location is known as the <b>global assembly cache(GAC)</b></li>
			<li>Placing code in the GAC is simple, you just place the assembly containing the code in the directory containing this cache.</li>
		</ul>
	</li>		
</ol>
### Managed Code
<ol>
	<li>Code written using the .NET Framework is <b>managed</b> when it is executed
		<ul>
			<li>A stage usually referred to as <b>runtime</b></li>
		</ul>
	</li>
	<li>This means that the CLR looks after your applications by managing memory, handling security, allowing cross-language debugging, and so on</li>
</ol>
### Linking
<ol>
	<li>It is possible to split application code across multiple source code files, which are then compiled together into a single assembly.</li>
	<li>This process is known as <b>linking</b>
		<ul>
			<li>It is required because it is far easier to work with several smaller files than one enormous one</li>
			<li>You can seperate logically related code into an individual file so that it can be worked on independently.</li>
		</ul>
	</li>	
</ol>
### Applications You Can Write with C#
<ol>
	<li><b>Desktop applications</b>
		<ul>
			<li>Applications, such as Microsoft Office, that have familiar Windows look and feel about them.</li>
			<li>This is made simple by using <b>Windows Presentation Foundation(WPF)</b> module of the .NET framework</li>
		</ul>
	</li>
	<li><b>Windows Store Applications</b>
		<ul>
			<li>Windows 8 introduced a new type of application, known as Windows Store Application</li>
			<li>This type of application is designed primarily for touch devices, and it is usually run full screen, with minimum clutter, and an emphasis on simplicity</li>
			<li>You can create these applications in server ways including WPF</li>
		</ul>
	</li>
	<li><b>Cloud/Web Applications</b>
		<ul>
			<li>The .NET Framework includes a powerful system named <b>ASP .NET</b>, for generating web content dynamically, enabling personalization, security, and much more</li>
			<li>Additionally, these applications can be hosted and accessed in the Cloud, such as the Microsoft Azure platform</li>
		</ul>
	</li>
	<li><b>Web APIs</b>
		<ul>
			<li>An ideal framework for building RESTful HTTP services that support a broad variety of clients, including mobile devices and browsers</li>
		</ul>
	</li>
	<li><b>WCF services (Windows Communication Foundation)</b>
		<ul>
			<li>A way to create versatile distributed applications</li>
			<li>Using WCF, you can exchange virtually any data over local networks or the Internet using simple syntax regardless fo the language used to created a service or the system on which it resides</li>
		</ul>
	</li>
	<li>Any of these types might also require some form of database access, which can be achieved useing the <b>ADO.NET(Active Data Objects)</b> section of the .NET Framework</li>
		<ul>
			<li>Through ADO.NET <b>Entity Framework</b> or through <b>LINQ(Language Integrated Query)</b>, many other resources can be drawn on such as tools for creating networking components, outputting graphics, performing complex mathematical tasks, and so on</li>
		</ul>
</ol> 

## Chapter 2: Writing a C# Programming
### The Visual Studio 2015 Development Environment
<ol>
	<li>To reset settings to <b>Visual C# Development settings</b>, you simply have to import them
		<ul>
			<li>Select <b>Tools</b> --> <b>Import and Export Settings</b> --> <b>Reset All Settings</b></li>
		</ul>
	</li>
	<li>To see the <b>Server Tab</b>, click <b>View</b> --> <b>Server Explorer</b></li>
</ol>
### Desktop Applications
<ol>
	<li>When building desktop applications, we use Visual Studio's interface building blocks(known as <b>controls</b>)
		<ul>
			<li>These controls are available for drag and drop from the WPF toolbox</li>
		</ul>	
	</li>
	<li>The code is written in <b>XAML</b>, which is the language used to define user interfaces in WPF applications.</li>
	<li>Note that there is a .xaml file with an associated .cs file
		<ul>
			<li>This is because WPF (and .NET apps in general) are capable of keeping design aspects (such as text on a button) separate from the functionality aspectes(such as the even triggered when clicking a button)</li>
			<li>This is the reason for "code behind files"
				<ul>
					<li>Separate design files (.xaml) from functionality files(.cs)</li>
				</ul>
			</li>			
		</ul>
	</li>
</ol>

## Chapter 3:Variables and Expressions
### Basic C# Syntax
<ol>
	<li>A set of three backslashes(///) denotes that you wish to extract comments in the form of XML to create documentation for you programs
		<ul>
			<li>In order for this documentation to be created, the comment must follow the rules of XML documentation as described at https://msdn.microsoft.com/library/aa288481.aspx</li>
		</ul>
	</li>
</ol>
### Simple Types
<ol>
	<li>The <b>u</b> character before some variable names are shorthand for <b>unsigned</b>
		<ul>
			<li>This means you cant store negative numbers in variables of those types.</li>
		</ul>
	</li>
</ol>
### Literal Types
<ol>
	<li>You can specify strings as <b>verbatim</b>
		<ul>
			<li>This means that all characters contained between two double quotation marks are included in the string.</li>
			<li>Including end-of-line characters and characters that would otherwise need escaping</li>
			<li>To declare a string as verbatim, place the <b>@</b> character before the string
				<ul>
					<li>@"Verbatim string literal"</li>
				</ul>
			</li>
			<li>Useful when creating strings that represent file path values
				<ul>
					<li>Non-verbatim: "C:\\Temp\\MyDir\\MYFile.doc"</li>
					<li>Verbatim: @"C:\Temp\MyDir\MyFile.doc"</li>
				</ul>
			</li>
		</ul>
	</li>
</ol>
### Namespaces
<ol>
	<li>C#6 has introduced the <b>using static</b> keyword
		<ul>
			<li>This allows the inclusion of static members directly into the scope of a C# program</li>
			<li>For example you can use the <b>WriteLine()</b> by prefixing the name space befoe the method called
				<ul>
					<li><b>System.Console.WriteLine()</b></li>
				</ul>
			</li>
			<li>But if you put <b>using static System.Console</b> at the top of your program you no longer have to prefix the namespace to the method call
				<ul>
					<li><b>WriteLine()</b></li>
				</ul>
			</li>
		</ul>
	</li>
</ol>

## Chapter 4: Flow Control
### Boolean Bitwise and Assignment Operator
<ol>
	<li><b>&=</b>
		<ul>
			<li>var1 &= var2;</li>
			<li><b>var1</b> is assigned the value that is the result of <b>var1 & var2</b></li>
		</ul>
	</li>
	<li><b>|=</b>
		<ul>
			<li>var1 |= var2</li>
			<li><b>var1</b> is assigned the value that is the result of <b>var1 | var2</b></li>
		</ul>
	</li>
	<li><b>^=</b> (^ is XOR - exclusive OR)
		<ul>
			<li>var 1 ^= var2</li>
			<li><b>var1</b> is assigned the value that is the result of <b>var1 ^ var2</b></li>
		</ul>
	</li>
	<li><b>NOTE:</b> the &= and |= assignment opertors do not make use of the && and || conditional Boolean operators; that is, all operands are processed regardless of the value to the left of the assignment operator</li>
</ol>

## Chapter 5: More about Variables
### More Variable Types
<ol>
	<li><b>Enumerations</b>
		<ul>
			<li>Variable types that have a user defined discrete set of possible values that can be used in a human readable way</li>
		</ul>
	</li>
	<li><b>Structs</b>
		<ul>
			<li>Composite variable types made up of a user defined set of other variable types</li>
		</ul>
	</li>
	<li><b>Arrays</b>
		<ul>
			<li>Types that hold multiple variables of one type, allowing index access to the individual values</li>
		</ul>
	</li>
</ol>
### Explicit Conversions
<ol>
	<li><b>Overflow</b>
		<ul>
			<li>Attempting to fit a value into a variable when that value is too big for the type of that variable results in <b>overflow</b></li>
			<li>Two keywords exist for setting what is called <b>overflow checking context</b></li>
			<ul>
				<li><b>checked</b> - Will throw an <b>OverflowException</b> when code executed results in an overflow</li>
				<li><b>unchecked</b> - Will allow overflow to occur and will chop off values beyond the scope of the variable type
					<p>
						byte destinationVar;<br/>
						short sourceVar = 281;<br/>
						destinationVar = (byte)sourceVar;      (<b>Overflow!</b>)<br/>
						
						sourceVar value = 281<br/>
						destination value = 25<br/>

						281 = 1 0001 1001<br/>
						25  = 0 0001 1001<br/>
						255 = 0 1111 1111<br/>
					</p>
				</li>				
			</ul>
		</ul>
	</li>
</ol>




