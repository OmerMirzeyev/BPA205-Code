const form = document.getElementById("form");
const input = document.getElementById("input");
const list = document.getElementById("list");

form.onsubmit = function(e) {
    e.preventDefault();

    const value = input.value.trim();
    if (value === "") return;

    const li = document.createElement("li");

    const span = document.createElement("span");
    span.textContent = value;

    const doneBtn = document.createElement("button");
    doneBtn.textContent = "Done";
    doneBtn.className = "done-btn";

    const deleteBtn = document.createElement("button");
    deleteBtn.textContent = "Delete";
    deleteBtn.className = "delete-btn";

    doneBtn.onclick = function() {
        li.classList.toggle("done");
    };

    deleteBtn.onclick = function() {
        li.remove();
    };

    li.appendChild(span);
    li.appendChild(doneBtn);
    li.appendChild(deleteBtn);

    list.appendChild(li);

    input.value = "";
};