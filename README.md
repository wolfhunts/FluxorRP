Présentation de l'implémentation de Fluxor.

Fluxor et une librairie  qui implémente le patern flux.

Ce qui permet une gestion des state(Donnée) à un niveau global dans l'application.

Demo 01 et une branche montrant un site  fait de manière conventionnelle.

Demo02-03 Montre l'implémentation de la première brique de Fluxor.
La création d'un store et des state,feature et action des différent UseCase(Vue ou donnée à traiter)

Demo04,4A et la demo 05 Implémentation des effect
Il permettent de lancer des methode assynchrone et lorsqu'il on finis il peuvent lancer une  action qui demanderas au reducer de changer les state si besoin.

La Demo06
Implémentation d'un middelware les middelware peuvent êtres lancer au début ou à la fin d'un dispach d'une action. généralement pour faire des log. mais ellep euvent très bien servir à d'autre fin.

