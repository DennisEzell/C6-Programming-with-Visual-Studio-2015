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
			<li>Verbatim can also be used in conjunction with String interpolation
				<ul>
					<li>In the case of wanting double quotes in a verbatim string you have to use "" within the verbatim string</li>
						<p>
							Console.WriteLine(@”Foo “”Bar”” Baz “”Quux”””);<br/>
							 Foo “Bar” Baz “Quux”							
						</p>
					<li>To see an example of String interpolation used with a verbatim command, look at Ch05Ex01-TypeConversion</li>
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
						destinationVar = (byte)sourceVar;      (<b>Overflow!</b>)<br/><br/>						
						sourceVar value = 281<br/>
						destination value = 25<br/><br/>
						281 = 1 0001 1001<br/>
						25  = 0 0001 1001<br/>
						255 = 0 1111 1111<br/>
					</p>
				</li>				
			</ul>
		</ul>
	</li>
</ol>

### String Manipulation
<ol>
	<li>A <b>String</b> type variable can be treated as a read-only array of <b>char</b> variables
		<ul>
			<li>This means you cant assign individual characters to a string the same way you would access them</li>
			<li>To get a <b>char array</b> that you can write to, you can use <b>ToCharArray()</b>
				<p>
					string myString = "A String";<br/>
					char[] myChars = myString.ToCharArray();
				</p>
			</li>			
		</ul>
	</li>
	<li>The <b>PadLeft()</b> and <b>PadRight()</b> commands can be used to include extra spacing to a string
		<p>
			&lt;string&gt;.PadLeft(10)
		</p>
	</li>
</ol>

## Chapter 6: Defining and Using Functions
### Parameters
<ol>
	<li>Careful reading of the C# specification shows a subtle distinction between <b>parameters</b> and <b>arguments</b>
		<ul>
			<li><b>Parameters</b> are defined as part of a function definition
				<ul>
					<li>Parameters are the part of the <b>signature</b> </li>
				</ul>
			</li>
			<li><b>Arguments</b> are passed to a function by calling code
				<ul>
					<li>Arguments are the values sent in from calling code to be used in the execution of the method</li>
				</ul>
			</li>
		</ul>
	</li>
</ol>

### Parameter Arrays
<ol>
	<li>C# enables you to specify one (and only one) special parameter for a function.</li>
	<li>This parameter <b>must be the last parameter</b> in the function definition, and is known as a <b>parameter array</b></li>
	<li>Parameter arrays enable you to call functions using a variable amount of parameters, and they are defined using the <b>params</b> keyword</li>
	<li>Similar to Java's <b>varargs</b> parameter</li>
</ol>

### Pass by Reference
<ol>
	<li>In C#, if you pass a primitive variable as an argument to a function, you pass it by value. Meaning any modification done to the value does not affect the variable's value in the scope from which the call was made.</li>
	<li>If you want to pass a variable explicitly by reference, you have to specify using the <b>ref</b> keyword before the parameter.</li>
</ol>

### Out Parameter
<ol>
	<li>You can specify that a given parameter is an <b>out parameter</b> by using the keyword <b>out</b></li>
	<li>In effect, this gives you almost exactly the same behaviour as a reference parameter, in that the value of the parameter at the end of the function execution is returned to the variable used in the function call</li>
	<li>Key differences between <b>ref</b> and <b>out</b> parameters
		<ul>
			<li>Whereas it is illegal to use an unassigned variable as a <b>ref</b> parameter, you can use an unassigned variable as an <b>out</b> parameter</li>
			<li>An <b>out</b> parameter must be treated as an unassigned value by the function that uses it</li>
		</ul>
	</li>
</ol>

### Delegates
<ol>
	<li><b>Delegates</b> are types that enable you to store reference to functions
		<ul>
			<li>This variable type refers to a function by:
				<ul>
					<li>Specifying the function's return type</li>
					<li>Specifying the function's signature</li>
				</ul>
			</li>
		</ul>
	</li>
</ol>

## Chapter 7: Error Handling

### try..catch...finally
<ol>
	<li>The C# language includes syntax for <b>structured exception handling (SEH)</b></li>
	<li>The following illustrates SEH
		<p>
			try<br/>
			{<br/>
			&nbsp;&nbsp;...<br/>
			}<br/>
			catch (&lt;exceptionType&gt; e) when (filterIsTrue)<br/>
			{<br/>
			&nbsp;&nbsp;&lt;await methodName(e);&gt<br/>
			&nbsp;&nbsp;...<br/>
			}<br/>
			finally<br/>
			{<br/>
			&nbsp;&nbsp;...<br/>
			}<br/>
		</p>
	</li>
	<li><b>await</b> can be used optionally within the <b>catch</b> or <b>finally</b> blocks
		<ul>
			<li><b>await</b> is used to support advanced asnchronous programming techniques.</li>
		</ul>
	</li>
	<li>C#6 introduced a concept called <b>exception filtering</b>
		<ul>
			<li>This is done by ading the <b>when</b> keyword after the exception type expression</li>
			<li>If that exception type occurs and the filter expression is true, only then will the code in the <b>catch</b> block execute</li>
		</ul>
	</li>
</ol>

## Chapter 8: Introduction to OO Programming

### Properties & Fields
<ol>
	<li>Fields are class members that store and provide direct access to object state data</li>
	<li>Properties differ from fields in that they dont provided direct access to the underlying data
		<ul>
			<li>Property values are accessed via methods
				<ul>
					<li>Common use is the <b>automatic property</b> notation of: {get; set;}</li>
				</ul>
			</li>
		</ul>
	</li>
</ol>

### Static Constructors
<ol>
	<li>When using static members in a class, you might want to intialize these members beforehand.</li>
	<li>This is where a <b>static constructor</b> can be used
		<ul>
			<li>A class can have only a <b>single</b> static constructor</li>
			<li>Contains no access modifiers or parameters</li>
			<li>Cannot be called directly</li>
		</ul>
	</li>
	<li>Static constructor execution occurs when:
		<ul>
			<li>An instance of a class is created</li>
			<li>A static member of the class containing the static constructor is accessed</li>
		</ul>
	</li>
	<li>No matter how many instances of a class are created, the static constructor will be called only once.</li>
</ol>

### Interfaces
<ol>
	<li>When interfaces need to change, you should create a new interface that <b>extends</b> the old one
		<ul>
			<li>This is to ensures that you dont break code implementing the original interface</li>
			<li>Including a version number in the new interface iteration, such as V2, has become a standard way of achieving this</li>
		</ul>
	</li>
</ol>

### Disposable Objects
<ol>
	<li>If an object implements the <b>IDisposable</b> interface and implements the <b>Dispose()</b> method, then this object will free up any system resources just before it goes out of scope</li>
	<li>For instance say the &lt;ClassName&gt; implements the IDisposable interface.
		<p>
			&lt;ClassName&gt; &lt;VariableName&gt; = new &lt;ClasName&gt;();<br/>
			...<br/>
			using(&lt;VariableName&gt)<br/>
			{<br/>
			&nbsp;&nbsp;...<br/>			
			}<br/>			
		</p>
	</li>	
	<li>After the <b>using</b> block executes, then the Class will call its Dispose() method to free up resources</li>
</ol>

### Inheritance
<ol>
	<li>When using inheritance from a base class, the question of member accessibility becomes an important one
		<ul>
			<li>Private members of the base class are not accessible from a derived class, but public ones are.</li>
			<li>The <b>protected</b> accessibility modifier gives access to base class members but protected members are treated as <b>private</b> by external code</li>
		</ul>
	</li>
	<li>Members of a base class can also be <b>virtual</b>
		<ul>
			<li>Which means that the member can be overridden by the class that inherits it.</li>
			<li>Therefore, the derived class can provide an alternative implementation for the member</li>
			<li>This alternative implementation does not delete the original base class code, but shields it from external code</li>
			<li>If no alternative is supplied, then any external code automatically uses the base class implementation.</li>
			<li>Virtual members <b>cannot be private</b>, as this would defeat the purpose of marking the member as virtual</li>
		</ul>
	</li>
	<li>A class may also be <b>sealed</b>, which means it cannot be used as a base class.</li>
</ol>

### Polymorphism
<ol>
	<li>Polymorphism allows us to use variable types to refer to base/derived class instances</li>
	<li>Typically this is done by using a variable of the base class type, and assigning it an instance of the derived class</li>
	<li><b>Note:</b> You cant call methods that are defined only in the derived class when using a base class variable type.
		<p>
			Animal myAnimal = new Cow();<br/>
			myAnimal.EatFood() // EatFood is defined in both the base class (Animal) and derived class (Cow). This will call the Cow.EatFood() <br/>			
			<br/>
			myAnimal.Moo() // Will not compile because you cant access the dervied class method (Cow.Moo()) from a base class variable. <br/>
			<br/>
			Cow myCow = (Cow)myAnimal;<br/>
			myCow.Moo(); //Will work when we cast the base class into a derived class variable. <br/>
		</p>
	</li>
</ol>

### Relationships Between Objects
<ol>
	<li><b>Containment</b>
		<ul>
			<li>One class contains another</li>
			<li>This is similiar to inheritance but allows the containing class to control access to the members of the contained class</li>
			<li>Allows additional processing before using the members of a contined class</li>
		</ul>
	</li>
	<li><b>Collections</b>
		<ul>
			<li>One class acts as a container for multiple instances of another class.</li>
			<li>This is similiar to having arrays of objects, but collections have additional functionality, including indexing, sorting, resizing, and more.</li>
			<li>Collections are basically an array with bells and whistles
				<ul>
					<li>They are implemented as a class and usually implement additional functionality such as Add() and Remove() methods</li>
				</ul>
			</li>
		</ul>
	</li>
</ol>

## Chapter 9: Defining a Class
### Class Definitions in C#
<ol>
	<li>By default, classes are declared as <b>internal</b>, meaning only code in the current project will have access to it.</li>
	<li>If a base class is specified, it must be the first thing after the colon, with interfaces specifed afterwards.</li>
</ol>

### Constructor Execution Sequence
<ol>
	<li>Consider the following class structures
		<ul>
			<li>Base Class:</li>
			<p>
				public class MyBaseClass<br/>
				{<br/>
				&nbsp;&nbsp;public MyBase()<br/>
				&nbsp;&nbsp;{<br/>
				&nbsp;&nbsp;}<br/><br/>
				&nbsp;&nbsp;public MyBaseClass(int i)<br/>
				&nbsp;&nbsp;{<br/>
				&nbsp;&nbsp;}<br/>
				}
			</p>
			<li>Derived Class:</li>
			<p>
				public class MyDerivedClass : MyBaseClass<br/>
				{<br/>
				&nbsp;&nbsp;public MyDerivedClass()<br/>
				&nbsp;&nbsp;{<br/>
				&nbsp;&nbsp;}<br/><br/>
				&nbsp;&nbsp;public MyDerivedClass(int i)<br/>
				&nbsp;&nbsp;{<br/>
				&nbsp;&nbsp;}<br/><br/>
				&nbsp;&nbsp;public MyDerivedClass(int i, int j)<br/>
				&nbsp;&nbsp;{<br/>
				&nbsp;&nbsp;}<br/>				
				}
			</p>
		</ul>
	</li>
	<li>You could instantiate the <b>MyDerivedClass</b> as follows
		<ul>
			<li>MyDerivedClass myObj = new MyDerivedClass();</li>
			<li>The following sequence of events will occur
				<ul>
					<li>System.Object.Object() constructor will execute</li>
					<li>MyBaseClass.MyBaseClass() constructor will execute</li>
					<li>MyDerivedClass.MyDerivedClass() constructor will execute</li>
				</ul>
			</li>
		</ul>
		<ul>
			<li>You could also do</li>
			<li>MyDerivedClass myObj = new MyDerivedClass(4)</li>
				<ul>
					<li>System.Object.Object() constructor will execute</li>
					<li>MyBaseClass.MyBaseClass() constructor will execute</li>
					<li>MyDerivedClass.MyDerivedClass(int i) constructor will execute</li>
				</ul>
		</ul>
	</li>
	<li>If you wanted to control what base class constructor is called, you can use a <b>constructor initializer</b>
		<ul>
			<li>Do this by specifying the base class constructor to be be called from a derived class constructor</li>
			<p>
				public class MyDerivedClass : MyBaseClass<br/>
				{<br/>
				&nbsp;&nbsp;public MyDerivedClass()<br/>
				&nbsp;&nbsp;{<br/>
				&nbsp;&nbsp;}<br/><br/>
				&nbsp;&nbsp;public MyDerivedClass(int i)<br/>
				&nbsp;&nbsp;{<br/>
				&nbsp;&nbsp;}<br/><br/>
				&nbsp;&nbsp;public MyDerivedClass(int i, int j)<b> : base(i)</b><br/>
				&nbsp;&nbsp;{<br/>
				&nbsp;&nbsp;}<br/>				
				}
			</p>
			<li>Now when we invoke the 2 argument constructor it will call the single argument constructor of the base class</li>
			<p>
				MyDerivedClass MyObj = new MyDerivedClass(4,8);
			</p>
			<li>This will cause the below sequence of events
				<ul>
					<li>System.Object.Object() constructor will execute</li>
					<li>MyBaseClass.MyBaseClass(int i) constructor will execute</li>
					<li>MyDerivedClass.MyDerivedClass(int i,int j) constructor will execute</li>
				</ul>
			</li>
		</ul>
	</li>
	<li>You can also call another constructor in the same class using the <b>this</b> keyword
		<p>
			public class MyDerivedClass : MyBaseClass<br/>
			{<br/>
			&nbsp;&nbsp;public MyDerivedClass()<b> : this(5,6)</b><br/>
			&nbsp;&nbsp;{<br/>
			&nbsp;&nbsp;}<br/><br/>
			&nbsp;&nbsp;public MyDerivedClass(int i)<br/>
			&nbsp;&nbsp;{<br/>
			&nbsp;&nbsp;}<br/><br/>
			&nbsp;&nbsp;public MyDerivedClass(int i, int j) : base(i)<br/>
			&nbsp;&nbsp;{<br/>
			&nbsp;&nbsp;}<br/>				
			}
		</p>
		<li>This will cause the below sequence of events
			<ul>
				<li>System.Object.Object() constructor will execute</li>
				<li>MyBaseClass.MyBaseClass(int i) constructor will execute</li>
				<li>MyDerivedClass.MyDerivedClass(int i,int j) constructor will execute</li>
				<li>MyDerivedClass.MyDerivedClass() constructor will execute</li>
			</ul>
		</li>
	</li>
</ol>

### Class vs Structs
<ol>
	<li>Structs are value types</li>
	<li>Classes are reference types</li>
</ol>

### Shallow Copy vs Deep Copy
<ol>
	<li>The <b>IClonable</b> interface enables you to deep copy by implementing its <b>Clone()</b> method</li>
	<li>This method returns a value of type <b>System.Object</b></li>
</ol>

## Chapter 10: Defining Class Members

### Defining Fields
<ol>
	<li>Fields can use the keyword <b>readonly</b></li>
	<li>This means the field can be assigned a value <b>only</b> during constructor execution or by initial assignment</li>
</ol>

### Defining Methods
<ol>
	<li>Methods are also defined using PascalCasing</li>
	<li>In addition to the <b>static</b> keyword, methods can also use the following keywords
		<ul>
			<li><b>virtual: </b>The method can be overridden</li>
			<li><b>abstract: </b>The method must be overridden in non-abstract dervied classess (only permitted in abstract classes)</li>
			<li><b>override: </b>The method overrides a base class method (it must be used if a method is being overridden)</li>
			<li><b>extern: </b>The method definition is found elsewhere</li>
		</ul>
	</li>
</ol>

### Defining Properties
<ol>
	<li>C#6 introduced a new feature called <b>expression based properties</b>
		<p>
		//Field used by property<br/>
		private int myDoubledInt = 5;<br/><br/>
		//Property<br/>	
		public int MyDoubledIntProp => (myDoubledInt * 2);		
		</p>
	</li>
</ol>

### Automatic Properties
<ol>
	<li>An automatic property is declared with a simplified syntax and the C# compiler fills in the blaks for you
		<p>
			public int MyIntProp { get; set; }
		</p>
	</li>
	<li>You can create an automatic property in Visual Studio by typing <b>'prop'</b> and then prest <b>TAB twice</b></li>
</ol>

### Hidden and Overridden Methods
<ol>
	<li>When you inherit a non-abstract method from a base class, you also inherit an implementation.</li>
	<li>If the inherited member is <b>virtual</b> then you can override the base class implementation with the <b>override</b> keyword</li>
	<li>Regardless of whether the inherited member is <b>virtual</b>, you can <b>hide</b> the implementation</li>
	<li>You can hide base class implementation using the <b>new</b> keyword on the method declaration</li>
	<li>Difference between <b>Overriding</b> and <b>Hiding</b>
		<ul>
			<li><b>Overriding</b> the base method will essentially overwrite the base class defined method with functionality with the subclass defined functionality</li>
			<li><b>Hiding</b> the base class simply allows the subclass to define its own implementation for that method, but does not overwrite the existing implementation if the method is called from as base class reference</li>
			<li>Whether you override or hide a base class member, you still have access from the derived class</li>
			<li>In the case of hiding, you would use the base.&lt;HiddenMethod&gt;()</li>
			<li>See Chapter 10 Exercise - HideVsOverride for more information</li>
		</ul>
	</li>
</ol>

### Implementing Interfaces
<ol>
	<li>It us useful to define implementations in <b>base</b> classes as virtual so that <b>derived</b> classes can replace the implementation, rather than hide it.</li>
	<li>The thing to remember when using interfaces as your reference variable is that the variable will always use the method implementation of the class that implemented the method</li>
</ol>

### Partial Class Definitions
<ol>
	<li>By declaring a class to be <b>partial</b> you are splitting the definition of a class across multiple files</li>
	<li>You can use this to logically group code
		<ul>
			<li>One file for functionality (code behind)</li>
			<li>One file for presentation (designer)</li>
		</ul>
	</li>
	<li>You can also define <b>Partial Methods</b>
		<ul>
			<li>These methods are defined in one partial class without a body, and implemented in another partial class</li>
			<li>Partial methds can be static, but they are always <b>private</b> and have only <b>void</b> return values</li>
			<li>They cannot use the keywords
				<ul>
					<li>virtual</li>
					<li>abstract</li>
					<li>override</li>
					<li>new</li>
					<li>sealed</li>
					<li>extern</li>
				</ul>
			</li>
			<li>The reason behind these limitations is that when you compile code that contains a partial method definition without an implementation, the compiler actually removes the method entirely.
				<ul>
					<li>It also removes any calls to the method</li>
				</ul>
			</li>
		</ul>
	</li>
</ol>

## Chapter 11: Collections, Comparisons, and Conversions

### The 3 concepts defined
<ol>
	<li><b>Collections: </b> enable you to maintain groups of objcets.
		<ul>
			<li>Unlike arrays, collections can include more advanced functionality, such as controlling access to objects they contain</li>
			<li>Searching and sorting</li>
		</ul>
	</li>
	<li><b>Comparisons: </b> When dealing with objects, you often want to make comparisions between them
		<ul>
			<li>Comparisons allow you to compare objects in a number of ways
				<ul>
					<li>Opeartor overloading</li>
					<li>Interface implementation such as <b>IComparable</b> and <b>IComparer</b></li>
				</ul>
			</li>
		</ul>
	</li>
	<li><b>Conversions: </b> In addition to <b>casting</b> a variable, you can also customize your type conversions</li>
</ol>

### Collections
<ol>
	<li>Collection classes in general are used for maintaining lists of objects, and may expose more functionality than simple arrays</li>
	<li>Much of this functionality comes through implementing interfaces from <b>System.Collections</b> namespace</li>
	<li>Serveral interfaces in the <b>System.Collections</b> namespace provide basic collection functionality
		<ul>
			<li><b>IEnumerable: </b>Provides the capability to loop through items in a collection</li>
			<li><b>ICollection: </b>Provides the capability to obtain the number of items in a collection and copy items int a simtple array type
				<ul>
					<li>Inherits from IEnumerable</li>
				</ul>
			</li>
			<li><b>IList: </b>Provides a list of items for a collection along with the capabilities for accessing these items, and some other basic capabilities related to lists of items
				<ul>
					<li>Inherits from IEnumerable and ICollection</li>
				</ul>
			</li>
			<li><b>IDictionary: </b>Similar to IList, but provides a list of items accessible via a key value, rather than an index
				<ul>
					<li>Intherits form IEnumerable and ICollection</li>
				</ul>
			</li>
		</ul>
	</li>
</ol>

### Defining Collections
<ol>
	<li>To create your own strongly-typed collection, you can derive your collection from from a class, such as <b>System.Collections.CollectionBase</b>
		<ul>
			<li>An abstract class that supplies muc of the implementation of a collection for you</li>
		</ul>
	</li>
	<li>The <b>CollectionBase</b> class exposes the interfaces<b>IEnumerable, ICollection, and IList</b>, but provides only some of the required implementations
		<ul>
			<li>Provided are the <b>Clear()</b> and <b>RemoveAt()</b> methods of <b>IList</b></li>
			<li>Also the <b>Count</b> property of <b>ICollection</b></li>
		</ul>
	</li>
	<li>With the exception of the items listed above, you must implement all other required members
		<ul>
			<li>To facilitate this, <b>CollectionBase</b> provides two protected properties that enable access to the stored objects themselves
				<li><b>List</b> gives you access to the items through an <b>IList</b> interface</li>
				<li><b>InnerList</b> which is the ArrayList object used to store items</li>
			</li>
		</ul>
	</li>
	<li>The ability to strongly type our collections means we no longer have to cast our arrays (since the array only works with the types we specify instead of System.Object)
		<p>
			public class Animals : CollectionBase<br/>
			{<br/>
			&nbsp;&nbsp;public void Add(Animal newAnimal)<br/>
			&nbsp;&nbsp;{<br/>
			&nbsp;&nbsp;&nbsp;List.Add(newAnimal);<br/>			
			&nbsp;&nbsp;}<br/><br/>
			&nbsp;&nbsp;public void Remove(Animal oldAnimal)<br/>
			&nbsp;&nbsp;{<br/>
			&nbsp;&nbsp;&nbsp;List.Remove(oldAnimal);<br/>			
			&nbsp;&nbsp;}<br/>
			&nbsp;&nbsp;public Animals(){}<br/>
			}
		</p>
	</li>
</ol>

### Indexers
<ol>
	<li>An <b>indexer</b> is a special kind of property that you can add to a class to provide array-like access</li>
	<li>An indexer allows for object retrieval without casting by index</li>
	<li>An example of an indexer on the Animals coolection:
		<p>
		public class Animals : CollectionBase<br/>
		{<br/>
		&nbsp;...<br/>
		&nbsp;public Animal this[int animalIndex]<br/>
		&nbsp;{<br/>
		&nbsp;&nbsp;get{ return (Animal)List[animalIndex]; }<br/>
		&nbsp;&nbsp;set{ List[animalIndex] = value; }<br/>		
		&nbsp;}<br/>		
		}
		</p>
	</li>
	<li>The indexer will now allow us to retrieve values from our Animals array in a fashion such as
		<ul>
			<li>New retrival method: <b>animalCollection[0].Feed()</b></li>
			<li>Instead of : <b>((Animal)animalCollection[0]).Feed()</b></li>
		</ul>
	</li>
</ol>

### Keyed Collections and IDictionary
<ol>
	<li><b>DictionaryBase</b>, like CollectionsBase, implements some (but not all) of the members obtained through its supported interfaces</li>
	<li>Like CollectionBase, the <b>Clear</b> and <b>Count</b> members are implented, although <b>RemoveAt()</b> isnt because it is a method on the IList interface
		<ul>
			<li>IDictionary does, however, have a <b>Remove()</b> method, which is one of the methods you should implement in a custom collection class based on <b>DictionaryBase</b></li>
		</ul>
	</li>
	<li>The key differences between dealing with IDictionary vs IList Collectiosn
		<ul>
			<li><b>Add()</b>
				<ul>
					<li>Takes two parameters, a key and a value</li>
					<li>The dictionary collection has a member alled <b>Dictionary</b> inherited from <b>DictionaryBase</b> which is on the <b>IDictionary</b> inteface</li>
					<li>This interface has its own <b>Add()</b> method, which takes two object parameters</li>
					<li>Your implementation takes a string value as a key and a <b>&lt;ObjectType&gt;</b> as the data to store alongside this key</li>
				</ul>
			</li>
			<li><b>Remove()</b>
				<ul>
					<li>Takes a key parameter, rather then an object reference</li>
					<li>The item with the key value specified is removed</li>
				</ul>
			</li>
			<li><b>INdexer</b>
				<ul>
					<li>Uses a strink key value, rather than an index, which is used to access the stored item via the <b>Dictionary</b> inherited memeber</li>
					<li>Again, casting is necessary here</li>
				</ul>
			</li>
		</ul>
	</li>
	<li>You can use a <b>foreach</b> loop which, for each iteration, will return a derived class of <b>DictionaryEntry</b> structs
		<p>
		foreach(DictionaryEntry entry in animalCollection)<br/>
		&nbsp;{<br/>
		&nbsp;&nbsp;WriteLine($"New {entry.Value.ToString()} object added to "+<br/>
		&nbsp;&nbsp;&nbsp;$"custom collection, Name = {((Animal)entry.Value).Name}");<br/>		
		&nbsp;}
		</p>
	</li>
</ol>

### Iterators
<ol>
	<li>An <b>iterator</b> is a block of code that supplies all the values to be used in a foreach block in sequence</li>
	<li>To iterate over a class, use a method called <b>GetEnumerator()</b> with a return type of <b>IEnumerator</b></li>
	<li>To iterate over a class memeber, such as a method, use <b>IEnumberable</b></li>
	<li>Within an interator block, you select the values to be used in the foreach loop by using the <b>yield</b> keyword
		<p>
			yield return &lt;value&gt;
		</p>
	</li>
	<li>See Chapter 11 Exercise: Iterators</li>
</ol>

### Deep Copying
<ol>
	<li>The <b>System.Object.MemberwiseClone()</b> will copy one objects fields into another
		<ul>
			<li>But if those fields are objects it just copies the reference of the object</li>
			<li>This is known as a <b>Shallow copy</b></li>
		</ul>
	</li>
	<li>A <b>Deep Copy</b> makes a full copy of an object without maintaining the same object field references
		<ul>
			<li>The standard .NET Framework way of doing this is to implement the <b>IClonable</b> interface which has a singel method <b>Clone()</b></li>
			<li><b>Clone()</b> takes no parameters and returns an <b>object</b> type result.</li>
			<li>The CardApplication exercise has had the Deep Copy functionality added to it via the Clone() methods on Deck.cs and Card.cs</li>
		</ul>
	</li>
</ol>

### The <b>is</b> Operator
<ol>
	<li>Despite its name, the <b>is</b> operator isnt a way to determine whether an object is a certain type</li>
	<li>Instead, it enables you to check whether an object either is or <b>can be converted into</b> a given type</li>
	<li>Syntax:
		<p>
			&lt;operand&gt; is &lt;type&gt;
		</p>
	</li>
	<li>The possible results of this expression are:
		<ul>
			<li>If &lt;type&gt; is a class type, then the result is <b>true</b> if &lt;operand&gt; is of that type, if it inherits from that type, or if it can be boxed into that type</li>
			<li>If &lt;type&gt; is an interface type, then the result is <b>true</b> if &lt;operand&gt; is of that type or it is a type type that implements that interface</li>
			<li>If &lt;type&gt; is a value type, then the result is <b>true</b> if &lt;operand&gt; is of that type or it is a type that can be unboxed into that type</li>
			<li>See Chapter 11 Exercies IsOpertor</li>
		</ul>
	</li>
</ol>

### Operator Overloading
<ol>
	<li><b>Operator Overloading</b> enables you to use standard operators, such as +, >, and so on, with classes that you design.</li>
	<li>This is useful because you can perform whatever processing you want in the implementation of the overloaded operator</li>
	<li>Below is an example of a class overloading the <b>+</b> operator
		<p>
			public class AddClass1<br/>
			&nbsp;{<br/>
			&nbsp;&nbsp;public int val;<br/>
			&nbsp;&nbsp;public static AddClass1 operator +(AddClass1 op1, AddClass1 op2)<br/>
			&nbsp;&nbsp;{<br/>
			&nbsp;&nbsp;&nbsp;&nbsp;AddClass1 returnVal = new AddClas1();<br/>
			&nbsp;&nbsp;&nbsp;&nbsp;returnVal.val = op1.val + op2.val;<br/>
			&nbsp;&nbsp;&nbsp;&nbsp;return returnVal;
			&nbsp;&nbsp;}<br/>
			&nbsp;}
		</p>
	</li>
	<li>The following operators can be overloaded
		<ul>
			<li><b>Unary Operators</b>
				<ul>
					<li>+  -  !  ~  ++  --  true  false</li>
				</ul>
			</li>
			<li><b>Binary Operators</b>
				<ul>
					<li>+  -  *  /  %  &  |  ^  &lt;&lt;  &gt;&gt;</li>
				</ul>
			</li>
			<li>Comparison operators
				<ul>
					<li>==  !=  &lt;  &gt;  &lt;=  &gt;=</li>
				</ul>
			</li>
		</ul>
	</li>
	<li>If you overload the <b>true</b> and <b>false</b> operators, then you can use classes in Boolean expressions
		<ul>
			<li>Suc as <b>if(op1){}</b></li>
		</ul>
	</li>
	<li>Check out the Card Application project to see how Operator Overloading is implemented</li>
</ol>

### IComparable and IComparer Interfaces
<ol>
	<li>The <b>IComparable</b> and <b>IComparer</b> interfaces are the standard way to compare objects in the .NET Framework
		<ul>
			<li><b>IComparable:</b> is implemented in the class of the object to be compared and allows comparison between thta object and another object
				<ul>
					<li>Exposes a single method <b>CompareTo()</b>, which accepts an object</li>
				</ul>
			</li>			
			<li><b>IComparer:</b> is implemented in a seperated class, which allows comparisons between any two objects
				<ul>
					<li>Exposes the single method <b>Compare()</b>, which accepts two objects and returns an integer just like <b>CompareTo()</b></li>
				</ul>
			</li>
			<li>In both cases, the parameters supplied to the methods are of the type <b>System.Object</b></li>
			<li>Objects passed to <b>Comparer.Compare()</b> are checked to determine whether they support IComparable. If they do, then that implementation is used</li>
			<li>Null values are allowed, and are interpreted as being "less than" any other object</li>
			<li>Strings are processed according to current culture</li>
			<li>Strings are processed in a case-sensitive way, to make it non-case-sensitive use <b>CaseInsenitiveComparer</b></li>
		</ul>
	</li>
	<li>Note that some classes in the System.Collections namespace, including <b>CollectionBase</b>, dont expose a method for sorting.
		<ul>
			<li>If you want to sort a collection you have derived from this class, then you have to do a bit more work (See Chapter 11 exercise SortList)</li>
		</ul>
	</li>
</ol>

### Overloading Conversion Operators
<ol>
	<li>You can define both <b>implicit</b> and <b>explicit</b> conversions between types</li>
	<li>This is necessary if you want to convert between types that arent related - if there is no inheritance relationship between them and no shared interfaces</li>
	<li>Suppose you want to define implicit conversion between ConvClass1 and ConvClass2
		<p>
		&nbsp;&nbsp;ConvClass1 op1 = new ConvClass1()<br/>
		&nbsp;&nbsp;ConvClass2 op2 = op1
		</p>
	</li>
	<li>You could alos define an explicit conversion
		<p>
		&nbsp;&nbsp;ConvClass1 op1 = new ConvClass1();<br/>
		&nbsp;&nbsp;ConvClass2 op2 = (ConvClass2)op1
		</p>
	</li>
	<li>Below illustrates the code behind both the implicit and explicit conversions
		<p>
		public class ConvClass1<br/>
		&nbsp;{<br/>
		&nbsp;&nbsp;public int val;<br/>
		&nbsp;&nbsp;public static <b>implicit</b> operator ConvClass2(ConvClass1 op1)<br/>
		&nbsp;&nbsp;&nbsp;{<br/>
		&nbsp;&nbsp;&nbsp;&nbsp;ConvClass2 returnVal = new ConvClass2();<br/>		
		&nbsp;&nbsp;&nbsp;&nbsp;returnVal.val = (int)op1.val;<br/>		
		&nbsp;&nbsp;&nbsp;&nbsp;return returnVal;<br/>		
		&nbsp;&nbsp;&nbsp;}<br/>		
		}
		</p>
		<br/>
		<p>
		public class ConvClass2<br/>
		&nbsp;{<br/>
		&nbsp;&nbsp;public int val;<br/>
		&nbsp;&nbsp;public static <b>explicit</b> operator ConvClass1(ConvClass2 op1)<br/>
		&nbsp;&nbsp;&nbsp;{<br/>
		&nbsp;&nbsp;&nbsp;&nbsp;ConvClass1 returnVal = new ConvClass1();<br/>		
		&nbsp;&nbsp;&nbsp;&nbsp;checked{ returnVal.val = (int)op1.val;}<br/>		
		&nbsp;&nbsp;&nbsp;&nbsp;return returnVal;<br/>		
		&nbsp;&nbsp;&nbsp;}<br/>		
		}		
		</p>
	</li>
</ol>

### The <b>as</b> operator
<ol>
	<li>The <b>as</b> operator converts a type into a specified reference type</li>
	<p>
		&lt;operand&gt; <b>as</b> &lt;type&gt;
	</p>
	<li>Possible applications of the <b>as</b> operator:
		<ul>
			<li>If &lt;operand&gt; is of type &lt;type&gt;</li>
			<li>If &lt;operand&gt; can be implicitly converted to type &lt;type&gt;</li>
			<li>If &lt;operand&gt; can be boxed into type &lt;type&gt;</li>
		</ul>
	</li>
	<li>If no conversion form &lt;operand&gt; to &lt;type&gt; is possible, then the result of the expression will be <b>null</b></li>
</ol>

## Generics

### What are Generics?
<ol>
	<li>To best illustrate, recall the collections classes from previous chapters
		<ul>
			<li>Basic collections can be contained in classes such as <b>ArrayList</b>, but that such collections suffer from being <b>untyped</b></li>
			<li>This requires that you cast <b>object</b> items into whatever type of object you actually stored in the collection</li>
			<li>Because anything that inherits for <b>System.Object</b> (which is practically everything) can be stored in the ArrayList</li>
			<li>Assuming that certain types are all that is contained in a collection can lead to the exceptions being throw, and code logic breaking down</li>
		</ul>
	</li>
	<li>The next best alternative to using untyped Collections was for us to define our own strongly typed collection class
		<ul>
			<li>We did this by deriving our Collection class from <b>CollectionBase</b> and providing our own methods for adding, removing, and indexers</li>
			<li>This is where we encountered the problem that everytime we create a new class that needs to be held in a collection, we had to do one of the following:
				<ul>
					<li>Use a collection class you have already made that can contain items of the new type</li>
					<li>Create a new collection class that can hold items of the new type, implementing all the required methods</li>
				</ul>
			</li>
		</ul>
	</li>
	<li><b>Generic Classes</b> make coding a lot simpler
		<li>A generic class is built around whatever type, or types, you supply during <b>instantiation</b>, enabling you to strongly type an object with hardly any effort at all</li>
		<li>In the context of collections, creating a "collection of type <b>T</b> objects" is as simple as providing the type in the parameter tag &lt;&gt; of the collection type
			<p>
				CollectionClass<b>&lt;ItemClass&gt;</b> items = new CollectionClass&lt;ItemClass&gt;();<br/>				
				items.Add(new ItemClass());
			</p>
		</li>
	</li>
	<li>A side note on Generics in C#
		<ul>
			<li>Usuallyu, when you create a class, it is compiled into a type that you can the use in your code</li>
			<li>This is not the case for a generic class, as they are resolved at runtime</li>
			<li>The .NET runtime allows generic classes to be dynamically generated as and when you need them</li>
			<li>A give generic class <b>A</b> of <b>B</b> wont exist until you ask for it by instantiating it</li>
			<li>Key difference from Java's <b>type erasure</b></li>
		</ul>
	</li>
</ol>

### Nullable Types
<ol>
	<li>This generic type allows us to get around a minor issue with value types</li>
	<li>One of the ways in which <b>value</b> types differ from <b>reference</b> types is that they must contain a value</li>
	<li>This is where generics gives you the ability to have nullable value types
		<ul>
			<li><b>System.Nullable&lt;int&gt; nullableInt</b></li>
		</ul>
	</li>
	<li>Nullable types allow variables that would otherwise be vlaue types, to be null</li>
	<li>An alternative syntax for declaring a value type as nullable:
		<ul>
			<li><b>int? nullableInt</b></li>
		</ul>
	</li>
	<li>What happens when one or both values in an operator evaluation that involves two nullable value are <b>null</b>?
		<ul>
			<li>The answer is for all simple nullable tyeps other than <b>bool?</b>, the result of the operation is <b>null</b></li>
			<li>Which can be interpreted as "unable to compare"</li>
		</ul>
	</li>
	<li>Since Nullables are basically wrappers for value types, you can access the underlying value of a Nullable by using <b>Nullable.Value</b> property</li>
</ol>

### The ?? operator
<ol>
	<li>The <b>??</b> operator, known as the <b>null coalescing opertor</b>
		<ul>
			<li>A binary operator that enables you to supply an alternative value to use for expressions that might evaluate into null</li>
			<li>The following statements are functionally equivalent:
				<p>
					op1 ?? op2<br/>
					op1 == null ? op2 : op1
				</p>
			</li>
			<li>This means you use the <b>??</b> operator to provide default values to use if a nullable type is null
				<p>
					int? op1 = null;<br/>
					int result = op1 * 2 ?? 5;
				</p>
				<ul>
					<li>result will have the value of <b>5</b> since the evaluation of op1 * 2 results in null.</li>
				</ul>
			</li>
		</ul>
	</li>
</ol>

### The ?. Operator
<ol>
	<li>Known as the <b>Elvis operator</b> or the <b>null condition operator</b></li>
	<li>Helps to overcome code ambiguity by burdensome null checking</li>
	<li>It checks the type for value and assigns it null if one is not present</li>
	<li>Example:
		<p>
			int? count = customers.orders?.Count()
		</p>
		<ul>
			<li>Using the <b>?.</b> operator results in int? count being set to null when there are no orders for the customer</li>
		</ul>
	</li>
	<li>We can also define default values if we combine the ?. with the ??
		<p>
			int? count = customer.orders?.Count() ?? 0;
		</p>
		<ul>
			<li>Sets count to 0 if there are no orders for the customer</li>
		</ul>
	</li>
</ol>

### Generic List (List&lt;T&gt;)
<ol>
	<li>Rather than derive a class from <b>CollectionBase</b> and implement the required methods, it can be quicker and easier simply to use the <b>List&lt;T&gt;</b> generic collection type</li>
	<li>An added bonus here is that many of the methods you normally have to implement, such as <b>Add()</b>, are implemented for you.</li>
	<li>An alternative way to achieve the same as extending collection base is to extend a Generic list of your particular type
		<ul>
			<li><b>public class Animals : List&lt;Animal&gt; {}</b></li>
		</ul>
	</li>
	<li>To sort a <b>List&lt;T&gt;</b>, you can supply an <b>IComparable&lt;T&gt;</b> interface on th etype to be sorted, or supply an <b>Icomparer&lt;T&gt;</b>interface</li>
	<li>Alternatively, you can supply a <b>generic delegate</b> as a sorting method
		<ul>
			<li>There are two generic delegate types you can use:
				<ul>
					<li><b>Comparison&lt;T&gt;</b>: A delegate type for a method used for sorting, with the following return type and parameters
						<p>
							int method (T objectA, T objectB)
						</p>
					</li>
					<li><b>Predicate&lt;T&gt;</b>: A delegate type for a method used for searching, with the following return type and parameters:
						<p>
							bool method (T targetObject)
						</p>
					</li>
				</ul>
			</li>
		</ul>
	</li>
</ol>

### Method Group
<ol>
	<li>There are many situations in which you can use a <b>method group</b> to implicitly create delegates</li>
	<li>Consider the following call for leveraging a delegate (See Chapter 12 SearchSortGenericList exercise)
		<p>
		&nbsp;&nbsp;Comparison&lt;Vector&gt; sorter = new Comparison&lt;Vector&gt;(VectorDelegate.Compare);<br/>
		&nbsp;&nbsp;route.Sort(sorter);
		</p>
	</li>
	<li>The above delegate call can be reduced to the below code
		<p>
		&nbsp;&nbsp;route.Sort(VectorDelegate.Compare);
		</p>
	</li>
	<li>The reference to VectorDelegate.Compare without the (), is refereed to as a <b>method group</b></li>
	<li>The <b>Sort()</b> method obviously needs an instance of a comparison interface, but the compiler realizes and creates one for you from the method you supply.</li>
</ol>

### Index Initializers
<ol>
	<li>A new feature inttroduced in C#6 is <b>index initializers</b></li>
	<li>This concept allows initialization of indices inside the object initializer
<p>

```C#
var names = new Dictionary<int, string>
	{
		[1] = "Dennis",
		[2] = "Daniel"	
	}
```
</p>
	</li>
	<li>You can also use index intializers in <b>expression-bodied methods</b>
<p>

```C#

&public Dictionary<int, string> GetNames() => new Dictionary<int, string> { [1] = "Dennis", [2] = "Daniel"};
```
</p>
	</li>
</ol>

### <b>default</b> Keyword
<ol>
	<li>When creating generic classes, you do not know what types are being used to create the generic instances
		<ul>
			<li>Could be value types (cant be assigned <b>null</b>)</li>
			<li>Could be reference types</li>
		</ul>
	</li>
	<li>By using the <b>default</b> keyword, you can assign a null value if the type is a reference type, or a default value if it is a value type
<p>

```C#
public MyGenericClass()
{
	innerT1Object = default(T1);
}
```
</p>
	</li>
</ol>

### Constraining Types
<ol>
	<li>Generic types in which no restrictions are placed upon the types they can used are known s <b>unbounded</b>
		<ul>
			<li>You can only make the assumption that your types either inherit from or can be boxed into <b>System.Object</b></li>
		</ul>
	</li>
	<li>By <b>constraining</b> types, it is possible to restrict the types that can be used to instantiate a generic class</li>
	<li>To constrain a generic class, we use the <b>where</b> keyword
<p>

```C#
class MyGenericClass<T> where T : constraint { . . . }
```
</p>
		<ul>
			<li>Here, <b>constraint</b> defines what the constraint is.</li>
		</ul>
	</li>
	<li>For a code example, refer to Chapter 12 exercise: <b>DefineGenericClass</b></li>
	<li>It is possible to use one type parameter as a constraint on another through the base-class constraint such as:
		<ul>
			<li>&nbsp;&nbsp;class MyGenericClass&lt;T1, T2&gt; <b>where T2 : T1</b> { . . .}</li>
			<li>Here, T2 must be the same type as T1 or inherit from T1</li>
			<li>This is known as a <b>naked type constraint</b> meaning that one generic type parameter is used as a constraint on another</li>
		</ul>		
	</li>	
</ol>

### Inheriting Constraints
<ol>
	<li>When inheriting from a generic class, your new class generic must be <b>at least as constrained</b> as the inherited class
<p>

```C#
class SuperFarm<T> : Farm<T> where T : SuperCow {...}
```
</p>
		<ul>
				<ul>
					<li>This works because T is constrained to Animal in Farm&lt;T&gt;, and constraining it to SuperCow is constraining T to a subset of these values.</li>
				</ul>
			</li>
		</ul>
<p>

```C#
class SuperFarm<T> : Farm<T> where T : class {...}
```
</p>
		<ul>
				<ul>
					<li>This code will not compile because the T we are supplying SuperFarm is not as constrained in Farm</li>
				</ul>
			</li>
		</ul>		
	</li>
	<li>The inheriting class constraint must be a subset or equal to the original constraint class being inherited. </li>
</ol>

### Generic Methods
<ol>
	<li>You can also create generic methods that can be called to return any type so long as the type observes the specifed constraints
<p>

```C#
public Farm<U> GetSpecies<U>() where U : T => new Farm<U> { animals = Animals.FindAll(a => a is U).Cast<U>().ToList() };
````
</p>
		<ul>
			<li>The generic type parameter used here, U, is constrained by T, which is in turn constrained by the Farm&lt;T&gt; class to <b>Animal</b></li>
		</ul>
	</li>
	<li>For a code example, refer to Chapter 12 exercise: <b>DefineGenericClass</b> inside the <b>Farm.GetSpecies()</b> method</li>
</ol>

### Generic Delegates
<ol>
	<li>To define a generic delegat, you simply declare and use one or more generic type parameters
<p>

```C#
public delegate T1 MyDelegate&lt;T1, T2&gt;(T2 op1, T2 op2) where T1:T2;
```
</p>
	</li>
	<li>For a code example, see Chapter 12 Exercise: SearchSortGenericList
		<ul>
			<li>Usage of the Comparison&lt;T&gt; and Predicate&lt;t&gt;</li>
		</ul>
	</li>
</ol>

### Variance
<ol>
	<li>Variance is the collective term for <b>covariance</b> and <b>contravariance</b>, two concepts that were introduced in.NET 4</li>
	<li>Variance allows you to define <b>variant</b> type parameters on generic <b>interfaces and delegates</b> that allow for the conversion of one interface type to the other
	<li>Three important Variance terms:
		<ul>
			<li><b>Invariant:</b> Term used to describe interface typs that are unrelated</li>
			<li><b>Covariance:</b> In C# terms, an interface/delegate relationship that allows a base class typed interface variable to refer to a derived class reference</li>
			<li><b>Contravariance:</b> In C# terms this is the opposite of <b>Covariance</b>, allows dervied class typed interface to have a base class reference</li>
		</ul>
	</li>
	</li>
	<li>The easiest way to grasp that variance means is to compare it with <b>polymorphism</b></li>
	<li>Consider the following code
<p>

```C#
IMethaneProducer<Cow> cowMethanProducer = Cow;
IMethanProducer<Animal> animalMethaneProducer = cowMethaneProducer;
```
</p>
		<ul>
			<li>The above code will not work because the second line presupposes a relationship between the two interface types(Cow & Animal) that doesnt exist, so there is no way of converting one into the other...this is where Variance comes in</li>
			<li>To make the previous code work, the type parameter T for the IMethanProducer&lt;T&gt; interface must be <b>covariant</b></li>
		</ul>
	</li>
	<li>Covariance in more detail
		<ul>
			<li>To define a generic type parameter as covariant, you use the <b>out</b> keyword in the type definition</li>
		</ul>	
<p>

```C#
/// <summary>
/// Covaraint interface for the Animal class and 
/// its derived classes 
/// </summary>
/// <typeparam name="T">The covariant type</typeparam>
public interface IMethaneProducer<out T>{...}
```
</p>
		<ul>
			<li>For interface definitions, covariant type parameters can be used only as return values of methods or property <b>get</b> accessors.</li>
		</ul>
	</li>
	<li>Contravariance in more detail
		<ul>
			<li>To define a generic type parameter as contravariant, you use the <b>in</b> keyword in the type definition.</li>
		</ul>
<p>

```C#
/// <summary>
/// Contravariant interface for the derived classes 
/// of the Animal base class
/// </summary>
/// <typeparam name="T">The contravaraint type</typeparam>
public interface IGrassMuncher<in T> { }
```
</p>
		<ul>
			<li>For interface definitions, contravariant type parameters can be used only as method parameters, not as return types.</li>
		</ul>
	</li>
	<li>For more information regarding <b>Variance</b> see Chapter 12 Exercise: Variance</li>
</ol>
