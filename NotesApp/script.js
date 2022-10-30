const addBox = document.querySelector(".add-box"),
  popupBox = document.querySelector(".popup-box"),
  popupTitle = popupBox.querySelector("header p"),
  closeIcon = popupBox.querySelector("header i"),
  titleTag = popupBox.querySelector("input"),
  descTag = popupBox.querySelector("textarea"),
  addBtn = popupBox.querySelector("button");

const months = [
  "January",
  "February",
  "March",
  "April",
  "May",
  "June",
  "July",
  "August",
  "September",
  "October",
  "November",
  "December",
];

const notes = JSON.parse(localStorage.getItem("notes") || "[]");
let isUpdate = false,
  updateId;

addBox.addEventListener("click", () => {
  addBox.addEventListener("click", () => {
    // tytul popupu
    popupTitle.innerText = "Dodaj nową notatkę";
    // button
    addBtn.innerText = "Dodaj";

    // wyswietlenie popupu
    popupBox.classList.add("show");

    document.querySelector("body").style.overflow = "hidden";
  });
});

closeIcon.addEventListener("click", () => {
  isUpdate = false;

  //   czyścimy formularz
  titleTag.value = "";
  descTag.value = "";

  //   chowamy formularz
  popupBox.classList.remove("show");
  document.querySelector("body").style.overflow = "auto";
});

function showNotes() {
  if (!notes) return;
  document.querySelectorAll(".note").forEach((li) => li.remove());
  notes.forEach((note, id) => {
    let filterDesc = note.description.replaceAll("\n", "<br/>");
    let liTag = `<li class="note">
                        <div class="details">
                            <p>${note.title}</p>
                            <span>${filterDesc}</span>
                        </div>
                        <div class="bottom-content">
                            <span>${note.date}</span>
                            <div class="settings">
                                <i onclick="showMenu(this)" class="uil uil-ellipsis-h"></i>
                                <ul class="menu">
                                    <li onclick="updateNote(${id}, '${note.title}', '${filterDesc}')"><i class="uil uil-pen"></i>Edit</li>
                                    <li onclick="deleteNote(${id})"><i class="uil uil-trash"></i>Delete</li>
                                </ul>
                            </div>
                        </div>
                    </li>`;
    addBox.insertAdjacentHTML("afterend", liTag);
  });
}

showNotes();

addBtn.addEventListener("click", (e) => {
  e.preventDefault();
  //   przygotowanie danych
  let title = titleTag.value.trim();
  let description = descTag.value.trim();

  if (title || description) {
    // fajnie byłoby tez date wyswietlic
    let currentDate = new Date();
    let month = months[currentDate.getMonth()];
    let day = currentDate.getDate();
    let year = currentDate.getFullYear();

    // tworzymy obiekt notatki
    let noteInfo = { title, description, date: `${month} ${day}, ${year}` };

    // sprawdzamy czy jest update czy dodajemy nowa notatke
    if (!isUpdate) {
      notes.push(noteInfo);
    } else {
      isUpdate = false;
      //   podmieniamy notatke
      notes[updateId] = noteInfo;
    }
    //  zapisujemy do local storage
    localStorage.setItem("notes", JSON.stringify(notes));
    //    wymuszamy rerender notatek
    showNotes();
    //   chowamy popup
    closeIcon.click();
  }
});

function showMenu(elem) {
  elem.parentElement.classList.add("show");
  document.addEventListener("click", (e) => {
    if (e.target.tagName != "I" || e.target != elem) {
      elem.parentElement.classList.remove("show");
    }
  });
}

function deleteNote(noteId) {
  let confirmDel = confirm("Czy na pewno chcesz usunąć notatkę?");
  //   jak nie ma potwierdzenia to kończymy
  if (!confirmDel) return;
  //   a jak nie to korzystamy z metody splice i tniemy listę, zeby usunac zaznaczoną notatkę
  notes.splice(noteId, 1);
  //   na końcu robimy aktualizację local storage
  localStorage.setItem("notes", JSON.stringify(notes));
  //   i wywołujemy rerender
  showNotes();
}

function updateNote(noteId, title, filterDesc) {
  // po drodze jeszcze posprzatamy output z textArea na cos bardziej przyziemnego
  let description = filterDesc.replaceAll("<br/>", "\r\n");
  // przypiszemy id notatki do updateId, zeby ulatwic aktualizacje
  updateId = noteId;
  isUpdate = true;

  // pora na otworzenie popupu formularza
  addBox.click();
  //   oraz następnie przypisać dane notatki
  titleTag.value = title;
  descTag.value = description;
  //   na koncu podmienimy jeszcze tytul modalu
  popupTitle.innerText = "Uktualnij notatkę";
  //   oraz przycisk aktualizacji
  addBtn.innerText = "Aktualizuj";
}
