
# react-native-rnweb-test-components

## Getting started

`$ npm install react-native-rnweb-test-components --save`

### Mostly automatic installation

`$ react-native link react-native-rnweb-test-components`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-rnweb-test-components` and add `RNRnwebTestComponents.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNRnwebTestComponents.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNRnwebTestComponentsPackage;` to the imports at the top of the file
  - Add `new RNRnwebTestComponentsPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-rnweb-test-components'
  	project(':react-native-rnweb-test-components').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-rnweb-test-components/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-rnweb-test-components')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNRnwebTestComponents.sln` in `node_modules/react-native-rnweb-test-components/windows/RNRnwebTestComponents.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Rnweb.Test.Components.RNRnwebTestComponents;` to the usings at the top of the file
  - Add `new RNRnwebTestComponentsPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNRnwebTestComponents from 'react-native-rnweb-test-components';

// TODO: What to do with the module?
RNRnwebTestComponents;
```
  