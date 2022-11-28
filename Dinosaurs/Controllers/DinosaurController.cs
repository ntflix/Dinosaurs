using Microsoft.AspNetCore.Mvc;

namespace Dinosaurs.Controllers;

[ApiController]
[Route("[controller]")]
public class DinosaurController: ControllerBase {
    private static readonly Dinosaur[] Dinosaurs = new[] {
        new Dinosaur(
            era: Era.Archean,
            name: "Archeopteryx",
            description: "The first bird",
            rating: 5
        ),
        new Dinosaur(
            era: Era.Cambrian,
            name: "Trilobite",
            description: "The first arthropod",
            rating: 2
        ),
        new Dinosaur(
            era: Era.Carboniferous,
            name: "Dimetrodon",
            description: "The first mammal",
            rating: 3
        ),
        new Dinosaur(
            era: Era.Cretaceous,
            name: "Tyrannosaurus Rex",
            description: "The king of the dinosaurs",
            rating: 5
        ),
        new Dinosaur(
            era: Era.Devonian,
            name: "Arthropleura",
            description: "The first arthropod with a shell",
            rating: 1
        ),
    };

    private readonly ILogger<DinosaurController> _logger;

    public DinosaurController(ILogger<DinosaurController> logger) {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Dinosaur> Get() {
        return Dinosaurs;
    }
}