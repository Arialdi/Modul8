using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Modul8_1302200087.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController
    {
        private static List<string> Stars1 = new List<string> {
            "Tim Robbins", "Morgan Freeman", "Bob Gunton", "William Sadler"
        };

        private static List<string> Stars2 = new List<string> {
            "Marlon Brando", "Heath Ledger", "Aaron Echart", "Michael Caine"
        };

        private static List<string> Stars3 = new List<string>
        {
            "Christian Bale", "Al Pacino", "James Caan", "Diana Keaton"
        };

        private readonly ILogger<MovieController> _looger;

        List<Movie> movie1 = new List<Movie>();

        public MovieController(ILogger<MovieController> looger)
        {
            _looger = looger;
        }

        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            movie1.Add(new Movie("Overflow", "Satoru Mikami", Stars1, "For a long time ago satoru not meet his cousin. when he meet them looks much groong from them"));
            movie1.Add(new Movie("Masterpiece The Animation", "Yoshida Kokage", Stars2, "After his parents passed away many years ago, Enomoto Yuuji was adopted into the family of his childhood friends Yuna and Nina and their mother Mira. Now in high school and known as Yuuji Tsubakihara, he lives under the same roof as a pair of cute twins and a beautiful older woman. Although the shy, reserved Yuna and the outgoing, talented Nina are his family, Yuuji submits to his desires after witnessing Yuna turn down a confession. But as Yuuji and Yuna finally consummate their lifelong love, can Nina and Mira stand idly by?"));
            movie1.Add(new Movie("kimi no nawa", "Jun Maeda", Stars3, "Stars3Two teenagers share a profound, magical connection upon discovering they are swapping bodies.Things manage to become even more complicated when the boy and girl decide to meet in person."));

        }
    }
}
