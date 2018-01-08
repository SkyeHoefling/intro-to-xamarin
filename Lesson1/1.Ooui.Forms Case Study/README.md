## Ooui.Forms Case Study ##
Xamarin is a powerful platform that allows you to write native code across several different implementation platforms. Most notably it is used for cross-platform mobile applicaiton development targetting iOS, Android, Windows Phone and UWP. Xamarin also allows you to write native applications in macOS, Ubuntu and even a website. The power of Xamarin is using shared code to deliver an app across multiple platforms.

### Is Xamarin Really Native ##
When I talk to others about Xamarin I usually get some form of one of these questions:

* Is Xamarin truly native?
* How does it actually work?
* Since you are using a code sharing stategy how do you handle features that aren't available across all of the platforms

### Is Xamarin Truly Native ###
Yes, Xamarin is truly native it transpiles the C# down to the platform specific language and builds out the controls from there. I like to use Ooui.Forms as a way to demonstrate this because it is using Xamarin to build a web app. Since a browser can view the source of a website you can easily see the compiled code

### How Does it Actually Work ###
Xamarin's implementation takes the xamarin components and maps them to platform specific tools. It then converts the parameters that are used for the xamarin control to the platform control. This allows us to compile our apps as native apps and get all the performance that comes along with building a native app.

### Can You Access Platform Specific Features ###
Xamarin has device specific APIs which allow you to access any feature that is available on that device. You may need to write some code in your shared library that checks the device and then runs a specific implementation, but at the end of the day you are able to access that special iOS feature that isn't available on your android or other device.