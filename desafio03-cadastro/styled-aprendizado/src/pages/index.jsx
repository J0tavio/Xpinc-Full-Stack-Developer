import { useState, useEffect } from "react";

const Test = () => {
  const [name, setName] = useState("João");

  const handleChangeName = () => {
    setName((prev) => (prev === "João" ? "Carlos" : "João"));
  };

  useEffect(() => {
    alert("Renderizei");
  }, [name]);

  return (
    <div>
      <p>{name}</p>
      <button onClick={handleChangeName}>alterar</button>
    </div>
  );
};

export { Test };
