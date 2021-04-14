---
title: ModelBuilders
sidebarDepth: 5
---

# ModelBuilders - Introduction


Modelbuilders are an excellent way of adding metadata and attributes to the XAF TypesInfo system.

It's based around an [Fluent Interface Pattern](https://www.martinfowler.com/bliki/FluentInterface.html) and highly inspired by [EntityFramework's ModelBuilder's](https://docs.microsoft.com/en-us/ef/core/modeling/).

ModelBuilders are one of the many Non-Visual components of the Xenial.Framework, designed to encourage best practices and a more efficient workflow for large teams, but they bring equal benefits to smaller teams and projects as well.

## Installation

In your [platform agnostic module](https://docs.devexpress.com/eXpressAppFramework/118045/concepts/application-solution-components/application-solution-structure#projects) install the [Xenial.Framework](https://www.nuget.org/packages/Xenial.Framework/) package.

<code-group>
<code-block title=".NET CLI">

<div class="language-bash"><pre class="language-bash"><code>dotnet add package Xenial.Framework --version {{ $var['xenialVersion'] }}</code></pre></div>

</code-block>


<code-block title="PackageReference">

<div class="language-xml"><pre class="language-xml"><code>&ltPackageReference Include="Xenial.Framework" Version="{{ $var['xenialVersion'] }}" /&gt</code></pre></div>

</code-block>

<code-block title="Package Manager">

<div class="language-powershell"><pre class="language-powershell"><code>Install-Package Xenial.Framework -Version {{ $var['xenialVersion'] }}</code></pre></div>

</code-block>

<code-block title="Paket CLI">

<div class="language-bash"><pre><code>paket add Xenial.Framework --version {{ $var['xenialVersion'] }}</code></pre></div>

</code-block>

</code-group>

::: tip
By convention the platform agnostic module is usually named <Your Application>.Module.
If you're unfamiliar with the Command Line Interface (cli) you can always use the Nuget package manager.
Whilst the Xenial.Framework can of course be used in platform specific modules, for the purposes of this documentation emphasis will be given to its use in the platform agnostic module of your project.
:::

## Usage

There are several ways to use `ModelBuilders` in your application. From a fluent inline approach to complete [buddy type](https://stackoverflow.com/a/38373456/2075758). That requires a secondary utility class to specify the metadata for a business object.

Consider the following [XPO business class](https://docs.devexpress.com/eXpressAppFramework/113640/getting-started/in-depth-tutorial-winforms-aspnet/business-model-design/business-model-design-with-express-persistent-objects) based on the Contact/Task Management XAF Demo.

<<< @/guide/samples/DemoTaskBeforeModelBuilder.cs

::: tip
The Xenial Framework also supports Non-Persistent and EntityFramework but for the benefit of simplicity this documentation will focus on XPO Business Objects.
:::

### Naming conventions

The naming convention tries to be self explanatory.  
If the attribute is singular and describes *an attribute of* a business object it starts with the term `Has`.  
If the attribute is plural or describes *behavior of* a business object it starts with the term `With`.

::: tip
There are a lot of [Built-in Attributes](/guide/model-builders-built-in.md) provided by Xenial.  If you are missing one, that should be built into the framework, [let us know](https://github.com/xenial-io/Xenial.Framework/issues/)!
:::
