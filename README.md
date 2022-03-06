# Pull Request in Visual Studio

## Preconditions

GitHub Visual Studio Extension installed. Here is a quick [Guide](https://github.com/github/VisualStudio/blob/master/docs/getting-started/installing-github-for-visual-studio.md) on how to install the Extension.

The following [Tutorial](https://github.blog/2018-03-23-require-multiple-reviewers/#:~:text=To%20require%20multiple%20reviewers%20for,pull%20request%20to%20that%20branch.) will show how to activate brach protection, so that the pull request can only be merged when a certain number of reviewers gave their approval for the pull request.

## Pull Request Workflow

<p align="center">
  <img src="Doc/PullRequest_Flowchart.drawio.png" />
</p>

<br>

### Create a new Branch in Visual Studio

1. Open **Team Explorer** and click the **Branches** Button.   
![Team-Explorer-Branches](Doc/Team-Explorer-Branches.png)
2. Click the **New Branch** link.
3. In the "Enter a Branch Name Required" dialog box, enter a branch name.   
![Team-Explorer-Branches-Create](Doc/Team-Explorer-Branches-Create.png)
4. In the Based on section, use the drop-down list to choose whether you want to base your new branch off an existing branch.
5. The Checkout branch checkbox, which is on by default, automatically switches to the newly created branch. Toggle this option if you want to remain in the current branch.
6. Click the **Create** Button to create a new branch

<br>

### Create Commit to local Repository

1. Make changes in the source code.
2. Open **Team Explorer** and click the **Changes** Button.   
![Team-Explorer-Changes](Doc/Team-Explorer-Changes.png)
3. Here all changes that haven't been commited are listed.   
![Team-Explorer-Commit-Create](Doc/Team-Explorer-Commit-Create.png)
4. In the "Enter a commit Message" dialog box, enter a commit message.   
5. Click the **Commit All** Button to create a local commit.   

<br>

### Sync Commits with remote Repository

1. Open **Team Explorer** and click the **Sync** Button.   
![Team-Explorer-Sync](Doc/Team-Explorer-Sync.png)
2. Here all commits that haven't been pushed are listed.
![Team-Explorer-Push-commits](Doc/Team-Explorer-Push-Commits.png)
3. To sync your local Repository with the remote repository Click the **Push** link under "Outgoing Commits"

<br>

### Create a Pull Request in Visual Studio

1. Open a project in a GitHub repository.
2. Open **Team Explorer** and click the **Pull Requests** button to open the **GitHub** pane.
![Location of the pull requests button in the Team Explorer pane](Doc/Team-Explorer-PullRequest.png)
3. Click the **Create New** link above the list of pull requests for the repository.
4. Select the target branch by clicking the link.   
![The pull request creation form in the GitHub pane](Doc/Team-Explorer-PullRequest-Create.png)
5. Enter a pull request title and an optional description.
6. Click the **Create Pull Request** button.

<br>

### Create Review

1. Open **Team Expolrer** and click the **Pull Requests** button.
2. Double click on the pull request you want to add your review.
3. Click the **Add your review** link.  
![add_your_Raview](Doc/AddReview.png)
4. You can write your Review.   
5. To close your Review there are 3 options.   
![add_your_Raview](Doc/Approval.png)

#### Comment only
This is the simplest form of a review, you just write comments to the code someone else has wirtten.

#### Approval
You agree with all changes made to the pull request and give your **Approval** to merge the feature-branch with the main-branch.

#### Change Request
You dont agree with the changes made to the feature-branch and request that the developer further improves the feature-branch.

#### More Information
For more Information about reviewing a pull request in Visual Studio, see [here](https://github.com/github/VisualStudio/blob/master/docs/using/reviewing-a-pull-request-in-visual-studio.md).

<br>

### Close Pull Request without merging with main-Branch

<br>

## [Reviewing a Pull Request in Visual Studio](https://github.com/github/VisualStudio/blob/master/docs/using/reviewing-a-pull-request-in-visual-studio.md)

## [Adding Reviewer to Pull Request in GitHub](https://docs.github.com/en/pull-requests/collaborating-with-pull-requests/proposing-changes-to-your-work-with-pull-requests/requesting-a-pull-request-review)

## [Merging a Pull Request in GitHub](https://docs.github.com/en/pull-requests/collaborating-with-pull-requests/incorporating-changes-from-a-pull-request/merging-a-pull-request)
