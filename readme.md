Hello git, this is my first github experience and I am excited ☺️.
This is also for me to learn.

git status = checks your commits

git add /file name here/ = tracks your files

git commit -m 'enter message here' = is like taking a screenshot of your file at a certain time
and telling git to remember it

git add ./ = tells git to add all the files modified, created, or deleted to the git tracking

git log = git history

to revert back, first you need to copy the commit hash (ex. 937d38002bedd6f43a954fdded46c451942f8e2c )
and then exit the git log then use the command

git checkout /your commit hash here/ - this will revert back to the previous snapshot

head = the state or snapshot currently

git checkout master/main - reverts back to the latest snapshot

local repository = a project stored at your own device (laptop, desktop)

remote repository = a project stored at a cloud (github, gitlab, bitbucket).
This is also used to keep project in sync across different computers

git branch -M main = changes the branch name to main which is a standard practice nowadays

git remote add origin /github repository link/

git push -u origin main = push local to remote (computer files to github)

branching = allow you to create different version of your project. Whatever you make in the branch won't affect the original. if everything works out then you can later merge it in the original, if not then no worries the originil will remain safe and unchanged

git branch /branch-name/
if you want to check the branch out you can do:
git checkout /branch-name/
if you want to go back to main then you can do:
git checkout master/main

shortcut to create and automatically move to new branch:
git checkout -b branch name
