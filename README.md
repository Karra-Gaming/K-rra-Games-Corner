# K-rra-Games-Corner

# Way of Working

## OBS! Det första man ska göra i projektet:

* Clone repo

##Sen utgår vi från nedan.

När du har valt en task följ denna guide!

1. Hämta alla nya ändringar genom en pull request från developement. Kommando: git pull origin development

2. Skapa en ny branch med task id; Kommando: git checkout -b {branchName} Ex. git checkout -b Task-34 
[Förtydligande av branchName =>(Task-{taskens id-nummer}) Ex. Task-34]

3. Sen löser man tasken.

4a. När tasken är klar så pushar man sina sista ändringar i branchen.
OBS! När man pushar för första gången så skriver man ex. git push -u origin {branchName}

4b. Annars skriver man Kommando: git push 

5. Pull request via Github.com

6. Skriv i discord att du är klar med din task och gjort en pull request

7. Annan utvecklare kollar genom pull-requesten och godkänner och gillar posten på discord (DoD).

8. OBS! När pull-request är godkänd -> Taskägaren sätter tasken som klar på Azure boards. 

9. Branchskaparen tar bort branchen lokalt. Kommando: git bransch -d {branchName}; Ex. git branch - d Task-34

10. Branchskaparen tar bort branchen remote. Kommando: git push origin --delete {branchName} Ex. git push origin --delete Task-34