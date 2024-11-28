Présentation de l'implémentation de Fluxor.

Fluxor et une librairie qui implémente le pattern flux.

Ce qui permet une gestion des State (ensemble de données) à un niveau global dans l'application.

L'implémentation et fait sous diverse branche pour montrer les différentes fonctionnalités

Demo 01 et une branche montrant un site fait de manière conventionnelle.

Demo02-03 Montre l'implémentation de la première brique de Fluxor.

La création d'un store et des State,Feature et Action des différents UseCase( Vue ou donnée à traiter)

Demo04,4A et la demo05 implémentation des Effect

Ils permettent de lancer des méthodes asynchrone et lorsqu'ils ont finis ils peuvent lancer une action qui demandera au Reducer de changer les State si besoin.

La Demo06

Implémentation d'un Middelware, ils peuvent être lancés au début ou à la fin d'un Dispach d'une Action. Généralement pour faire des logs.
