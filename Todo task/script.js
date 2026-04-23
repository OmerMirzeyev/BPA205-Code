const input = document.getElementById("input");
const addBtn = document.getElementById("btn-add");
const list = document.getElementById("list");
const filterBtns = document.querySelectorAll(".filters button");

let todos = [];
let currentFilter = "all";

addBtn.onclick = () => {
    if (input.value.trim() === "") return;

    todos.push({
        text: input.value,
        done: false
    });

    input.value = "";
    render();
};
filterBtns.forEach(btn => {
    btn.onclick = () => {
        filterBtns.forEach(b => b.classList.remove("active"));
        btn.classList.add("active");
        currentFilter = btn.dataset.filter;
        render();
    };
});

/* RENDER */
function render() {
    list.innerHTML = "";

    let filtered = todos;

    if (currentFilter === "active") {
        filtered = todos.filter(t => !t.done);
    } else if (currentFilter === "done") {
        filtered = todos.filter(t => t.done);
    }

    filtered.forEach((todo, index) => {
        const li = document.createElement("li");
        li.className = todo.done ? "done" : "";

        li.innerHTML = `
            <div class="left">
                <div class="circle"></div>
                <span>${todo.text}</span>
            </div>
            <div class="delete">🗑</div>
        `;

        /* TOGGLE */
        li.querySelector(".circle").onclick = () => {
            todo.done = !todo.done;
            render();
        };

        /* DELETE */
        li.querySelector(".delete").onclick = () => {
            todos.splice(index, 1);
            render();
        };

        list.appendChild(li);
    });
}