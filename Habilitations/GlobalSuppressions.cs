// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Minor Code Smell", "S101:Types should be named in PascalCase", Justification = "BDD étant l'acronyme de Base De Données on le laisse en lettre capitale", Scope = "type", Target = "~T:Habilitations.connexion.ConnexionBDD")]
[assembly: SuppressMessage("Minor Code Smell", "S2292:Trivial properties should be auto-implemented", Justification = "Il est préférable d'avoir cela que de créer deux méthodes qui prennent de l'espace", Scope = "member", Target = "~P:Habilitations.modele.Developpeur.Pwd")]
