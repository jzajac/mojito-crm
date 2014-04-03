# Mojito CRM 
Contact management so easy you'll have time to enjoy a Mojito. 

Mostly a fun side project right now. 

## Installation

1. `npm install -g bower` (if you don't already have this)
2. `cd` to mojito root, which is the same level as README etc. 
3. `bower install` to obtain front end dependencies.
4. `Nake RestorePackages` to update Nuget packages.
5. `Nake SetupDatabase` to create database tables.

## Technologies

- NancyFX for a lightweight API
- AngularJS on the frontend
- [Nake](https://github.com/yevhen/Nake) for build scripting
