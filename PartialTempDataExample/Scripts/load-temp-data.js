document.querySelector("#load").addEventListener("click", () => {
  fetch("/Home/ShowPartial?searchTerm=NewTest")
    .then(response => {
      return response.text();
    })
    .then(result => {
      document.querySelector("#partial").innerHTML = result;
    });
});
