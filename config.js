// Single source of truth for everything tied to the GitHub account and repo.
// index.html uses the profile link, upload.html also uses the API base.
// Change the owner or repo here and nowhere else.
const SITE = (function () {
  const owner = "kucamaezakmi";
  const repo = "sveska";

  return Object.freeze({
    owner: owner,
    repo: repo,
    branch: "main",
    profileUrl: "https://github.com/" + owner,
    apiBase: "https://api.github.com/repos/" + owner + "/" + repo
  });
})();
